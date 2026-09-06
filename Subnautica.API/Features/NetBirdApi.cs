namespace Subnautica.API.Features
{
    using System;
    using System.Threading;
    using System.Net.NetworkInformation;
    using System.Text;

    using Subnautica.API.Extensions;

    using System.IO;
    using System.Diagnostics;

    public class NetBirdApi
    {
        /**
         *
         * Lobby Url Adresi
         *
         
         *
         */
        private string LobbyUrl { get; set; } = "https://servers.subnauticamultiplayer.com";

        /**
         *
         * Lobby Port Adresi
         *
         
         *
         */
        private string LobbyPort { get; set; } = "9443";

        /**
         *
         * NetworkId
         *
         
         *
         */
        private string NetworkId { get; set; } = "A068C242-A676-4C40-893B-50D450A81470";

        /**
         *
         * FileName
         *
         
         *
         */
        public string FileName { get; private set; } = "netbird.exe";

        /**
         *
         * Ping Değeri
         *
         
         *
         */
        private Ping Ping { get; set; }

        /**
         *
         * PingOptions Değeri
         *
         
         *
         */
        private PingOptions PingOptions { get; set; }

        /**
         *
         * Kurulum yolunu barındırır.
         *
         
         *
         */
        private string InstallationPath { get; set; } = null;

        /**
         *
         * Şuan işlem sağlanıyor mu?
         *
         
         *
         */
        private bool IsWaiting { get; set; } = false;

        /**
         *
         * Bağlanıyor mu?
         *
         
         *
         */
        private bool IsConnecting { get; set; } = false;

        /**
         *
         * Son çıktıyı barındırır.
         *
         
         *
         */
        public string LastOutput { get; private set; } = "";

        /**
         *
         * Son hatayı barındırır.
         *
         
         *
         */
        public string LastError { get; private set; } = "";

        /**
         *
         * NetBirdApi değerini barındırır.
         *
         
         *
         */
        private static NetBirdApi instance;

        /**
         *
         * NetBirdApi değerini barındırır.
         *
         
         *
         */
        public static NetBirdApi Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NetBirdApi();
                    instance.Initialize();
                }

                return instance;
            }
        }

        /**
         *
         * Manager sınıfını barındırır.
         *
         
         *
         */
        private Netbird.Netbird manager;

        /**
         *
         * Manager sınıfını barındırır.
         *
         
         *
         */
        private Netbird.Netbird Manager
        {
            get
            {
                if (manager == null)
                {
                    this.Refresh();
                }

                return manager;
            }
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public void Initialize()
        {
            this.Ping = new Ping();
            this.PingOptions = new PingOptions();
            this.PingOptions.DontFragment = true;
        }

        /**
         *
         * Kurulumu başlatır.
         *
         
         *
         */
        public void SetupNetbirdWithAdminPerms()
        {
            this.ExecuteCommand(Paths.AppData, true, 60000);
        }

        /**
         *
         * Komut çalışıyor mu?
         *
         
         *
         */
        public bool IsCommandRunning()
        {
            return this.IsWaiting;
        }

        /**
         *
         * Ağa bağlanıyor mu?
         *
         
         *
         */
        public bool IsConnectingToNetwork()
        {
            return this.IsConnecting;
        }

        /**
         *
         * Mevcut mu?
         *
         
         *
         */
        public bool IsExists()
        {
            return File.Exists(Paths.GetNetbirdPath(this.FileName));
        }

        /**
         *
         * Yenileme işlemi yapar.
         *
         
         *
         */
        public void Refresh()
        {
            this.manager = this.GetNetbirdDetails();
        }

        /**
         *
         * Netbird durumunu döner.
         *
         
         *
         */
        public Netbird.Netbird GetNetbirdDetails()
        {
            this.ExecuteCommand("status --json", timeout: 5000);

            return new Netbird.Netbird(this.LastOutput, this.LastError);
        }

        /**
         *
         * Bağlantıyı keser.
         *
         
         *
         */
        public void Disconnect()
        {
            this.ExecuteCommand($"down");
        }

        /**
         *
         * Sunucuya bağlanır.
         *
         
         *
         */
        public bool Connect()
        {
            Log.Info("Connecting to server!");

            this.IsConnecting = true;
            this.ExecuteCommand($"up --disable-auto-connect --network-monitor=false --setup-key {this.NetworkId} --management-url {this.GetLobbyUrlAddress()}");

            for (int i = 0; i < 5; i++)
            {
                this.Sleep(1000);
                this.Refresh();

                Log.Info("[Connection] IsReady(" + i + "): " + this.IsReady() + ", anyError: " + this.IsAnyError() + ", ERR: " + this.Manager.GetErrorContent());

                if (this.IsAnyError())
                {
                    this.Sleep(1000);
                    this.Disconnect();
                    this.Sleep(1000);
                    break;
                }

                if (this.IsReady())
                {
                    break;
                }
            }

            this.IsConnecting = false;
            return this.IsReady();
        }

        /**
         *
         * Kurulumu başlatır
         *
         
         *
         */
        public bool StartInstall()
        {
            this.ExecuteCommand("service install");
            this.ExecuteCommand("service start");
            return true;
        }

        /**
         *
         * PeerId Değerini döner.
         *
         
         *
         */
        public string GetPeerId()
        {
            return this.Manager.GetPeerId();
        }       
        
        /**
         *
         * PeerId Değerini döner.
         *
         
         *
         */
        public string GetPeerIp()
        {
            return this.Manager.GetPeerIp();
        }

        /**
         *
         * Kurulum bekleniyor mu?
         *
         
         *
         */
        public bool IsWaitingInstallation()
        {
            return this.Manager.IsWaitingInstallation();
        }

        /**
         *
         * Giriş yapmak için bekleniyor mu?
         *
         
         *
         */
        public bool IsWaitingLogin()
        {
            return this.Manager.IsWaitingLogin();
        }

        /**
         *
         * Aktif herhangi bir hata var mı?
         *
         
         *
         */
        public bool IsAnyError()
        {
            return this.Manager.IsAnyError() || this.Manager.Management.IsAnyError() || this.Manager.Signal.IsAnyError();
        }

        /**
         *
         * Hazır durumunu döner.
         *
         
         *
         */
        public bool IsReady()
        {
            if (this.IsWaitingInstallation())
            {
                return false;
            }

            if (this.IsWaitingLogin())
            {
                return false;
            }

            if (!this.Manager.Management.IsConnected)
            {
                return false;
            }

            if (!this.Manager.Signal.IsConnected)
            {
                return false;
            }

            if (!this.Manager.Relay.IsConnected)
            {
                return false;
            }

            /*
             // STUN NAT İçin
            if (!this.Manager.Stun.IsConnected)
            {
                return false;
            }
            */

            return true;
        }

        /**
         *
         * Host bağlantısı aktif mı?
         *
         
         *
         */
        public bool IsHostConnectionActive(string hostIp)
        {
            try
            {
                var status = this.Ping.Send(hostIp, 1000, Encoding.ASCII.GetBytes(System.Guid.NewGuid().ToString()), this.PingOptions).Status;
                return status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /**
         *
         * Host bağlantısı başarılı mı?
         *
         
         *
         */
        public bool IsHostConnected(string hostIp)
        {
            this.ExecuteCommand($"status --filter-by-status connected --filter-by-ips {hostIp}", timeout: 5000);
            return this.LastOutput.Contains(hostIp);
        }

        /**
         *
         * Eski kurulumu siler ve günceller.
         *
         
         *
         */
        public bool RemoveAndUpdateInstall()
        {
            try
            {
                var filePath = Paths.GetNetbirdPath(this.FileName);
                if (File.Exists(filePath))
                {
                    this.ExecuteCommand("service stop");
                    this.ExecuteCommand("service uninstall");

                    Thread.Sleep(250);
                    File.Delete(filePath);
                    Thread.Sleep(250);
                }

                var tempFilePath = Paths.GetNetbirdPath("netbird_temp.exe");
                if (File.Exists(tempFilePath))
                {
                    File.Copy(tempFilePath, filePath);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Netbird Update Exception: {ex}");
                Console.WriteLine($"Netbird Update Exception: {ex}");
                Thread.Sleep(3000);
            }

            return true;
        }

        /**
         *
         * komut çalıştırır.
         *
         
         *
         */
        public void ExecuteCommand(string command, bool isInstallion = false, int timeout = 10000)
        {
            try
            {
                this.IsWaiting = true;

                using (Process process = new Process())
                {
                    process.StartInfo.FileName               = isInstallion ? "cmd.exe" : Paths.GetNetbirdPath(this.FileName);
                    process.StartInfo.Arguments              = isInstallion ? string.Format(@"/c Subnautica.NetBird.exe ""{0}""", command) : command;
                    process.StartInfo.UseShellExecute        = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError  = true;
                    process.StartInfo.WindowStyle            = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow         = true;

                    if (isInstallion)
                    {
                        process.StartInfo.WorkingDirectory = Paths.GetLauncherGameCorePath();
                    }
                    else
                    {
                        process.StartInfo.WorkingDirectory = Paths.GetNetbirdPath();
                    }

                    StringBuilder output = new StringBuilder();
                    StringBuilder error = new StringBuilder();

                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                    {
                        process.OutputDataReceived += (sender, e) => {
                            if (e.Data == null)
                            {
                                outputWaitHandle.Set();
                            }
                            else
                            {
                                output.AppendLine(e.Data);
                            }
                        };
                        process.ErrorDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                errorWaitHandle.Set();
                            }
                            else
                            {
                                error.AppendLine(e.Data);
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();

                        if (process.WaitForExit(timeout) && outputWaitHandle.WaitOne(timeout) && errorWaitHandle.WaitOne(timeout))
                        {
                            this.LastOutput = output.ToString().Trim();
                            this.LastError  = error.ToString().Trim();
                        }
                        else
                        {
                            this.LastOutput = output.ToString().Trim();
                            this.LastError  = error.ToString().Trim();

                            if (this.LastError.IsNull())
                            {
                                this.LastError = "TIMEOUT";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.LastOutput = "";
                this.LastError = $"System.Exception: {ex.Message}:{ex.InnerException}";
            }
            finally
            {
                this.IsWaiting = false;
            }

            if (this.LastError.IsNotNull())
            {
                Log.Error($"Netbird API Exception: {this.LastError}, IS: " + isInstallion + ", T: " + timeout);
            }
        }

        /**
         *
         * Lobby Adresini döner.
         *
         
         *
         */
        private string GetLobbyUrlAddress()
        {
            return string.Format("{0}:{1}", this.LobbyUrl, this.LobbyPort);
        }

        /**
         *
         * İş parçacığını uyutur
         *
         
         *
         */
        private void Sleep(int time)
        {
            Thread.Sleep(time);
        }

        /**
         *
         * Console logu gönderir.
         *
         
         *
         */
        private void SendLog(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}