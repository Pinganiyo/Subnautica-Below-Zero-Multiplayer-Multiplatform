namespace Subnautica.Client.Core
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;

    using Subnautica.API.Features;
    using Subnautica.Client.Modules.MultiplayerMainMenuModule;

    using UnityEngine;

    public static class LanDiscovery
    {
        private const int DISCOVERY_PORT = 7667;
        private const string DISCOVERY_REQUEST = "SBZ_LAN_DISCOVER";
        private const string DISCOVERY_RESPONSE_PREFIX = "SBZ_LAN_SERVER|";

        private static UdpClient serverUdp;
        private static Thread serverThread;
        private static volatile bool isServerRunning;

        private static UdpClient clientUdp;
        private static Thread clientThread;
        private static volatile bool isClientRunning;
        private static Coroutine clientCoroutine;

        private static readonly ConcurrentQueue<Action> MainThreadQueue = new ConcurrentQueue<Action>();

        /**
         * Sunucu yayını başlatır.
         */
        public static void StartBroadcaster(int serverPort, string serverName)
        {
            StopBroadcaster();

            try
            {
                isServerRunning = true;
                serverUdp = new UdpClient();
                serverUdp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                serverUdp.ExclusiveAddressUse = false;
                serverUdp.EnableBroadcast = true;
                serverUdp.Client.Bind(new IPEndPoint(IPAddress.Any, DISCOVERY_PORT));

                serverThread = new Thread(() => ServerBroadcastLoop(serverPort, serverName))
                {
                    IsBackground = true
                };
                serverThread.Start();
                Log.Info($"[LAN Discovery] Server broadcaster started on port {DISCOVERY_PORT}");
            }
            catch (Exception ex)
            {
                Log.Error($"[LAN Discovery] StartBroadcaster failed: {ex}");
            }
        }

        /**
         * Sunucu yayınını durdurur.
         */
        public static void StopBroadcaster()
        {
            isServerRunning = false;
            try
            {
                serverUdp?.Close();
                serverUdp = null;
            }
            catch { }

            try
            {
                serverThread?.Abort();
                serverThread = null;
            }
            catch { }
        }

        /**
         * Sunucu yayın döngüsü
         */
        private static void ServerBroadcastLoop(int serverPort, string serverName)
        {
            byte[] responseData = Encoding.UTF8.GetBytes($"{DISCOVERY_RESPONSE_PREFIX}{serverPort}|{serverName}");

            while (isServerRunning)
            {
                try
                {
                    if (serverUdp?.Client == null)
                    {
                        break;
                    }

                    // 1. Periodik duyuru gönder
                    try
                    {
                        serverUdp.Send(responseData, responseData.Length, new IPEndPoint(IPAddress.Broadcast, DISCOVERY_PORT));
                        SendToAllInterfaceBroadcasts(serverUdp, responseData, DISCOVERY_PORT);
                    }
                    catch { }

                    // 2. Gelen istekleri kontrol et (1.5 sn bekle)
                    if (serverUdp.Client.Poll(1500000, SelectMode.SelectRead))
                    {
                        IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, 0);
                        byte[] receivedBytes = serverUdp.Receive(ref remoteEp);
                        string message = Encoding.UTF8.GetString(receivedBytes);

                        if (message == DISCOVERY_REQUEST)
                        {
                            serverUdp.Send(responseData, responseData.Length, remoteEp);
                        }
                    }
                }
                catch (SocketException)
                {
                    if (!isServerRunning) break;
                }
                catch (Exception ex)
                {
                    if (!isServerRunning) break;
                    Log.Error($"[LAN Discovery] Server loop error: {ex}");
                    Thread.Sleep(1000);
                }
            }
        }

        /**
         * İstemci LAN taramasını başlatır.
         */
        public static void StartClientDiscovery(Action<string, int, string> onServerDiscovered)
        {
            StopClientDiscovery();

            try
            {
                isClientRunning = true;
                clientUdp = new UdpClient();
                clientUdp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                clientUdp.ExclusiveAddressUse = false;
                clientUdp.EnableBroadcast = true;
                clientUdp.Client.Bind(new IPEndPoint(IPAddress.Any, 0));

                clientThread = new Thread(() => ClientListenLoop(onServerDiscovered))
                {
                    IsBackground = true
                };
                clientThread.Start();

                clientCoroutine = UWE.CoroutineHost.StartCoroutine(ClientDispatcherCoroutine());
                Log.Info("[LAN Discovery] Client discovery started");
            }
            catch (Exception ex)
            {
                Log.Error($"[LAN Discovery] StartClientDiscovery failed: {ex}");
            }
        }

        /**
         * İstemci LAN taramasını durdurur.
         */
        public static void StopClientDiscovery()
        {
            isClientRunning = false;
            try
            {
                clientUdp?.Close();
                clientUdp = null;
            }
            catch { }

            try
            {
                clientThread?.Abort();
                clientThread = null;
            }
            catch { }

            if (clientCoroutine != null)
            {
                UWE.CoroutineHost.StopCoroutine(clientCoroutine);
                clientCoroutine = null;
            }
        }

        /**
         * İstemci dinleme ve tarama döngüsü
         */
        private static void ClientListenLoop(Action<string, int, string> onServerDiscovered)
        {
            byte[] requestBytes = Encoding.UTF8.GetBytes(DISCOVERY_REQUEST);

            SendClientDiscoveryPings(requestBytes);

            long lastPingTicks = DateTime.UtcNow.Ticks;

            while (isClientRunning)
            {
                try
                {
                    if (clientUdp?.Client == null)
                    {
                        break;
                    }

                    // Her 2 saniyede bir ping gönder
                    if (new TimeSpan(DateTime.UtcNow.Ticks - lastPingTicks).TotalSeconds >= 2.0)
                    {
                        lastPingTicks = DateTime.UtcNow.Ticks;
                        SendClientDiscoveryPings(requestBytes);
                    }

                    if (clientUdp.Client.Poll(500000, SelectMode.SelectRead))
                    {
                        IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, 0);
                        byte[] receivedBytes = clientUdp.Receive(ref remoteEp);
                        string message = Encoding.UTF8.GetString(receivedBytes);

                        if (message.StartsWith(DISCOVERY_RESPONSE_PREFIX))
                        {
                            var parts = message.Substring(DISCOVERY_RESPONSE_PREFIX.Length).Split('|');
                            if (parts.Length >= 2 && int.TryParse(parts[0], out int port))
                            {
                                string serverName = parts[1];
                                string ipAddress = remoteEp.Address.ToString();

                                if (ipAddress == "::1" || ipAddress == "127.0.0.1")
                                {
                                    ipAddress = "127.0.0.1";
                                }

                                MainThreadQueue.Enqueue(() =>
                                {
                                    onServerDiscovered?.Invoke(ipAddress, port, serverName);
                                });
                            }
                        }
                    }
                }
                catch (SocketException)
                {
                    if (!isClientRunning) break;
                }
                catch (Exception ex)
                {
                    if (!isClientRunning) break;
                    Log.Error($"[LAN Discovery] Client listen error: {ex}");
                    Thread.Sleep(500);
                }
            }
        }

        private static void SendClientDiscoveryPings(byte[] requestBytes)
        {
            try
            {
                clientUdp?.Send(requestBytes, requestBytes.Length, new IPEndPoint(IPAddress.Broadcast, DISCOVERY_PORT));
                SendToAllInterfaceBroadcasts(clientUdp, requestBytes, DISCOVERY_PORT);
            }
            catch { }
        }

        private static void SendToAllInterfaceBroadcasts(UdpClient udp, byte[] data, int port)
        {
            try
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.OperationalStatus != OperationalStatus.Up || ni.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    {
                        continue;
                    }

                    foreach (UnicastIPAddressInformation uip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (uip.Address.AddressFamily == AddressFamily.InterNetwork && uip.IPv4Mask != null)
                        {
                            byte[] ipBytes = uip.Address.GetAddressBytes();
                            byte[] maskBytes = uip.IPv4Mask.GetAddressBytes();
                            byte[] broadcastBytes = new byte[4];
                            for (int i = 0; i < 4; i++)
                            {
                                broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);
                            }

                            udp?.Send(data, data.Length, new IPEndPoint(new IPAddress(broadcastBytes), port));
                        }
                    }
                }
            }
            catch { }
        }

        private static IEnumerator ClientDispatcherCoroutine()
        {
            while (isClientRunning)
            {
                if (!UserInterfaceElements.IsJoinGroupActive)
                {
                    StopClientDiscovery();
                    yield break;
                }

                while (MainThreadQueue.TryDequeue(out var action))
                {
                    try
                    {
                        action?.Invoke();
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"[LAN Discovery] Dispatcher error: {ex}");
                    }
                }

                yield return new WaitForSecondsRealtime(0.15f);
            }
        }
    }
}
