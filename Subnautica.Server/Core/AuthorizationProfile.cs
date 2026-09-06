namespace Subnautica.Server.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LiteNetLib;

    using MessagePack;

    using Story;

    using Subnautica.API.Extensions;
    using Subnautica.API.Features;
    using Subnautica.Network.Core;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Creatures;
    using Subnautica.Network.Models.Metadata;
    using Subnautica.Network.Models.Storage.Player;
    using Subnautica.Network.Models.Storage.Story.StoryGoals;
    using Subnautica.Network.Structures;
    using Subnautica.Server.Events;
    using Subnautica.Server.Events.EventArgs;

    using ServerModel = Subnautica.Network.Models.Server;

    [MessagePackObject]
    public class AuthorizationProfile
    {
        /**
         *
         * Oyuncu Id
         *
         
         *
         */
        [IgnoreMember]
        private string ipPortAddress;

        /**
         *
         * Oyuncu Id
         *
         
         *
         */
        [IgnoreMember]
        public byte PlayerId { get; set; }

        /**
         *
         * Benzersiz Oyuncu Id
         *
         
         *
         */
        [IgnoreMember]
        public string UniqueId { get; set; }

        /**
         *
         * Kullanıcı ip adresi
         *
         
         *
         */
        [IgnoreMember]
        public string IpAddress { get; set; }

        /**
         *
         * Kullanıcı IP & Port Adresi
         *
         
         *
         */
        [IgnoreMember]
        public string IpPortAddress 
        { 
            get
            {
                return this.ipPortAddress;
            }
            set
            {
                this.ipPortAddress = value;

                if (this.ipPortAddress.IsNotNull())
                {
                    this.IpAddress = this.ipPortAddress.Split(':')[0].Trim();
                }
                else
                {
                    this.IpAddress = null;
                }
            }
        }

        /**
         *
         * Oyuncu barındırıcı mı?
         *
         
         *
         */
        [IgnoreMember]
        public bool IsHost { get; set; } = false;

        /**
         *
         * Doğrulama Başarılı mı?
         *
         
         *
         */
        [IgnoreMember]
        public bool IsAuthorized { get; set; } = false;

        /**
         *
         * Tamamen Giriş Yapıldı mı?
         *
         
         *
         */
        [IgnoreMember]
        public bool IsFullConnected { get; set; } = false;

        /**
         *
         * NetPeer Bağlantısı
         *
         
         *
         */
        [IgnoreMember]
        public NetPeer NetPeer { get; set; }

        /**
         *
         * Oyuncunun kullandığı mevcut araç.
         *
         
         *
         */
        [IgnoreMember]
        public string VehicleId { get; set; }

        /**
         *
         * Mevcut hava durumu profili
         *
         
         *
         */
        [IgnoreMember]
        public string WeatherProfileId { get; set; }

        /**
         *
         * Kullanılan araçları barındırır.
         *
         
         *
         */
        [IgnoreMember]
        public bool IsStoryCinematicModeActive { get; set; } = false;

        /**
         *
         * Kullanılan odayı barındırır.
         *
         
         *
         */
        [IgnoreMember]
        public string UsingRoomId { get; set; }

        /**
         *
         * Son Saldırıya uğrama zamanı.
         *
         
         *
         */
        [IgnoreMember]
        public float LastAttackTime { get; set; }

        /**
         *
         * IsInVoidBiome Değeri
         *
         
         *
         */
        [IgnoreMember]
        public bool IsInVoidBiome { get; private set; }

        /**
         *
         * Kullanıcı Adı
         *
         
         *
         */
        [Key(0)]
        public string PlayerName { get; set; }

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        [Key(1)]
        public string SubrootId { get; set; }

        /**
         *
         * InteriorId Değeri
         *
         
         *
         */
        [Key(2)]
        public string InteriorId { get; set; }

        /**
         *
         * Mevcut Sağlık
         *
         
         *
         */
        [Key(3)]
        public float Health { get; set; } = 100f;

        /**
         *
         * Su Miktarı
         *
         
         *
         */
        [Key(4)]
        public float Water { get; set; } = 90.5f;

        /**
         *
         * Açlık Miktarı
         *
         
         *
         */
        [Key(5)]
        public float Food { get; set; } = 50.5f;

        /**
         *
         * Oyuncu Konumu
         *
         
         *
         */
        [Key(6)]
        public ZeroVector3 Position { get; set; } = new ZeroVector3();  

        /**
         *
         * Oyuncu Açısı
         *
         
         *
         */
        [Key(7)]
        public ZeroQuaternion Rotation { get; set; } = new ZeroQuaternion();

        /**
         *
         * Envanter eşyaları
         *
         
         *
         */
        [Key(8)]
        public StorageContainer InventoryItems { get; set; }

        /**
         *
         * Ekipman eşyaları
         *
         
         *
         */
        [Key(9)]
        public byte[] Equipments { get; set; }

        /**
         *
         * Ekipman eşyala Id'leri
         *
         
         *
         */
        [Key(10)]
        public Dictionary<string, string> EquipmentSlots { get; set; } = new Dictionary<string, string>(); 

        /**
         *
         * Hızlı slot id'leri
         *
         
         *
         */
        [Key(11)]
        public string[] QuickSlots { get; set; }

        /**
         *
         * Aktif slot değeri
         *
         
         *
         */
        [Key(12)]
        public int ActiveSlot { get; set; }

        /**
         *
         * Teknoloji pinlerini barındırır.
         *
         
         *
         */
        [Key(13)]
        public List<TechType> ItemPins { get; set; } = new List<TechType>();    

        /**
         *
         * PDA Bildirimlerini barındırır.
         *
         
         *
         */
        [Key(14)]
        public HashSet<NotificationItem> PdaNotifications { get; set; } = new HashSet<NotificationItem>();

        /**
         *
         * Kullanılan araçları barındırır.
         *
         
         *
         */
        [Key(15)]
        public HashSet<TechType> UsedTools { get; set; } = new HashSet<TechType>();

        /**
         *
         * Kişiye özel hedefleri barındırır.
         *
         
         *
         */
        [Key(16)]
        public HashSet<ZeroStoryGoal> SpecialGoals { get; set; } = new HashSet<ZeroStoryGoal>();

        /**
         *
         * RespawnPointId değerini barındırır.
         *
         
         *
         */
        [Key(17)]
        public string RespawnPointId { get; set; }

        /**
         *
         * IsInitialEquipmentAdded değerini barındırır.
         *
         
         *
         */
        [Key(18)]
        public bool IsInitialEquipmentAdded { get; set; }

        /**
         *
         * LastHypnotizeTime değerini barındırır.
         *
         
         *
         */
        [Key(19)]
        public float LastHypnotizeTime { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public AuthorizationProfile()
        {
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public AuthorizationProfile(NetPeer netPeer)
        {
            this.IpPortAddress = netPeer.ToString();
            this.NetPeer       = netPeer;
            this.PlayerId      = Server.Instance.GetNextPlayerId();
        }

        /**
         *
         * Doğrulama ve başlatma işlemini yapar.
         *
         
         *
         */
        public AuthorizationProfile Initialize(string playerName, string uniqueId)
        {
            uniqueId = Tools.CreateMD5(uniqueId);
            if (uniqueId.IsNull())
            {
                return null;
            }

            var profile = Server.Instance.Storages.Player.GetPlayerData(uniqueId, playerName);
            if (profile == null)
            {
                Log.Error("PLAYER DATA ERROR");
                return null;
            }
            
            profile.IsAuthorized  = true;
            profile.IpPortAddress = this.IpPortAddress;
            profile.NetPeer       = this.NetPeer;
            profile.PlayerName    = playerName;
            profile.UniqueId      = uniqueId;
            profile.PlayerId      = this.PlayerId;

            if (profile.InventoryItems == null)
            {
                profile.InventoryItems = StorageContainer.Create(6, 8);
            }
            
            return profile;
        }

        /**
         *
         * Oyuncu tamamen bağlandığında tetiklenir.
         *
         
         *
         */
        public void OnFullConnected()
        {
            this.IsFullConnected = true;

            try
            {
                PlayerFullConnectedEventArgs args = new PlayerFullConnectedEventArgs(this);

                Handlers.OnPlayerFullConnected(args);
            }
            catch (Exception e)
            {
                Log.Error($"AuthorizationProfile.OnFullConnected: {e}\n{e.StackTrace}");
            }
        }

        /**
         *
         * Oyuncu bağlantısı koptuğunda tetiklenir.
         *
         
         *
         */
        public void OnDisconnected()
        {
            this.IsFullConnected = false;

            try
            {
                PlayerDisconnectedEventArgs args = new PlayerDisconnectedEventArgs(this);

                Handlers.OnPlayerDisconnected(args);
            }
            catch (Exception e)
            {
                Log.Error($"AuthorizationProfile.OnDisconnected: {e}\n{e.StackTrace}");
            }

            Log.Info("DISCONNECT PLAYER -> " + this.PlayerName);

            Server.Instance.Logices.CreatureWatcher.OnPlayerDisconnected(this.PlayerId);
            Server.Instance.Logices.Bed.ClearPlayerBeds(this.PlayerId);
            Server.Instance.Logices.EntityWatcher.RemoveOwnershipByPlayer(this.UniqueId);
            Server.Instance.Logices.Hoverpad.RemovePlayerFromPlatform(this.UniqueId, true);
            Server.Instance.Logices.Interact.RemoveBlockByPlayerId(this.UniqueId);
            Server.Instance.Logices.PlayerJoin.OnPlayerDisconnected(this.UniqueId);
            Server.Instance.Logices.BaseMapRoom.OnPlayerDisconnected(this.UniqueId);
            Server.Instance.Logices.VoidLeviathan.OnPlayerDisconnected(this);

            this.SaveToDisk();

            ServerModel.PlayerDisconnectedArgs packet = new ServerModel.PlayerDisconnectedArgs()
            {
                UniqueId  = this.UniqueId
            };

            this.SendPacketToOtherClients(packet);
        }

        /**
         *
         * SubrootId Değerini değiştirir.
         *
         
         *
         */
        public void AddUsedTool(TechType techType)
        {
            if (!this.UsedTools.Contains(techType))
            {
                this.UsedTools.Add(techType);
            }
        }

        /**
         *
         * Biome döner.
         *
         
         *
         */
        public string GetBiome()
        {
            return LargeWorld.main.GetBiome(this.Position.ToVector3());
        }

        /**
         *
         * Oyuncunun öle bölgede olma durumunu değiştirir.
         *
         
         *
         */
        public void SetInVoidBiome(bool isInVoidBiome)
        {
            this.IsInVoidBiome = isInVoidBiome;
        }

        /**
         *
         * Araç id numarasını değiştirir.
         *
         
         *
         */
        public void SetVehicle(string vehicleId)
        {
            this.VehicleId = vehicleId;
        }

        /**
         *
         * SubrootId Değerini değiştirir.
         *
         
         *
         */
        public void SetSubroot(string subrootId)
        {
            this.SubrootId = subrootId;
        }

        /**
         *
         * InteriorId Değerini değiştirir.
         *
         
         *
         */
        public void SetInterior(string interiorId)
        {
            this.InteriorId = interiorId;
        }

        /**
         *
         * RespawnPointId Değerini değiştirir.
         *
         
         *
         */
        public void SetRespawnPointId(string respawnPointId)
        {
            this.RespawnPointId = respawnPointId;
        }

        /**
         *
         * Oyuncu konumunu değiştirir.
         *
         
         *
         */
        public void SetPosition(ZeroVector3 position, ZeroQuaternion rotation)
        {
            this.Position = position;
            this.Rotation = rotation;
        }

        /**
         *
         * En son hipnoz zamanını değiştirir.
         *
         
         *
         */
        public void SetLastHypnotizeTime(float lastHypnotizeTime)
        {
            this.LastHypnotizeTime = lastHypnotizeTime + 30f;
        }

        /**
         *
         * Envanter eşyalarını değiştirir.
         *
         
         *
         */
        public bool AddInventoryItem(StorageItem item)
        {
            this.RemoveInventoryItem(item.ItemId);
            this.InventoryItems.AddItem(item);
            return true;
        }

        /**
         *
         * Envanter idlerini değiştirir.
         *
         
         *
         */
        public void RemoveInventoryItem(string itemId)
        {
            this.InventoryItems.RemoveItem(itemId);
        }

        /**
         *
         * Hedefi tamamlar
         *
         
         *
         */
        public bool CompleteGoal(string storyKey, GoalType goalType, bool isPlayMuted)
        {
            return this.SpecialGoals.Add(new ZeroStoryGoal()
            {
                Key          = storyKey,
                GoalType     = goalType,
                IsPlayMuted  = isPlayMuted,
                FinishedTime = Server.Instance.Logices.World.GetServerTime(),
            });
        }

        /**
         *
         * Hipnoz aktif mi?
         *
         
         *
         */
        public bool IsHypnotized()
        {
            return this.LastHypnotizeTime > Server.Instance.Logices.World.GetServerTime();
        }

        /**
         *
         * Envanterde nesne mevcut mu?
         *
         
         *
         */
        public bool IsInventoryItemExists(string uniqueId)
        {
            return this.InventoryItems.IsItemExists(uniqueId);
        }

        /**
         *
         * Kullanılan odayı değiştirir.
         *
         
         *
         */
        public void SetUsingRoomId(string constructionId)
        {
            this.UsingRoomId = constructionId;
        }

        /**
         *
         * Oyuncu Saldırı altında durumunu değiştirir.
         *
         
         *
         */
        public void SetUnderAttack(float attackTime)
        {
            this.LastAttackTime = Server.Instance.Logices.World.GetServerTime() + attackTime;
        }

        /**
         *
         * Oyuncu Saldırı altında mı?
         *
         
         *
         */
        public bool IsUnderAttack()
        {
            return this.LastAttackTime > Server.Instance.Logices.World.GetServerTime();
        }

        /**
         *
         * Envanter eşyalarını değiştirir.
         *
         
         *
         */
        public void SetStoryCinematicMode(bool isActive)
        {
            this.IsStoryCinematicModeActive = isActive;
        }      

        /**
         *
         * Ekipman eşyalarını değiştirir.
         *
         
         *
         */
        public void SetEquipments(byte[] equipments, Dictionary<string, string> equipmentSlots)
        {
            this.Equipments = equipments;
            this.EquipmentSlots = equipmentSlots;
        }

        /**
         *
         * Hızlı slot id'lerini değiştirir.
         *
         
         *
         */
        public void SetQuickSlots(string[] slots)
        {
            this.QuickSlots = slots;
        }

        /**
         *
         * Aktif slot değerini değiştirir.
         *
         
         *
         */
        public void SetActiveSlot(int activeSlot)
        {
            this.ActiveSlot = activeSlot;
        }

        /**
         *
         * Teknoloji pinlerini değiştir
         *
         
         *
         */
        public void SetPinItems(List<TechType> itemPins)
        {
            this.ItemPins = itemPins;
        }

        /**
         *
         * Hava durumu profilini değiştirir
         *
         
         *
         */
        public void SetWeatherProfile(string profileId)
        {
            this.WeatherProfileId = profileId;
        }

        /**
         *
         * Bildirim siler.
         *
         
         *
         */
        public void RemoveNotification(string key)
        {
            this.PdaNotifications.RemoveWhere(q => q.Key == key);
        }

        /**
         *
         * Bildirim ekler.
         *
         
         *
         */
        public void AddNotification(NotificationManager.Group group, string key, bool isAdded)
        {
            var notification = this.PdaNotifications.FirstOrDefault(q => q.Key == key);
            if (notification == null) 
            {
                this.PdaNotifications.Add(new NotificationItem(group, key, !isAdded, false, true, 0));
            }
            else
            {
                if (!notification.IsViewed && !isAdded)
                {
                    notification.IsViewed = true;
                }
            }
        }

        /**
         *
         * Bildirim ekler.
         *
         
         *
         */
        public void SetNotificationVisible(string uniqueId, bool isVisible)
        {
            var notification = this.PdaNotifications.FirstOrDefault(q => q.Key == uniqueId);
            if (notification == null)
            {
                this.PdaNotifications.Add(new NotificationItem(NotificationManager.Group.Undefined, uniqueId, true, true, isVisible, 0));
            }
            else 
            {
                notification.IsPing    = true;
                notification.IsVisible = isVisible;
            }

        }

        /**
         *
         * Bildirim ekler.
         *
         
         *
         */
        public void SetNotificationColorIndex(string uniqueId, sbyte colorIndex)
        {
            var notification = this.PdaNotifications.FirstOrDefault(q => q.Key == uniqueId);
            if (notification == null)
            {
                this.PdaNotifications.Add(new NotificationItem(NotificationManager.Group.Undefined, uniqueId, true, true, true, colorIndex));
            }
            else 
            {
                notification.IsPing     = true;
                notification.ColorIndex = colorIndex;
            }

        }

        /**
         *
         * Sağlığı değiştirir.
         *
         
         *
         */
        public void SetHealth(float health)
        {
            this.Health = health;
        }

        /**
         *
         * Yiyecek miktarını değiştirir.
         *
         
         *
         */
        public void SetFood(float food)
        {
            this.Food = food;
        }

        /**
         *
         * Su miktarını değiştirir.
         *
         
         *
         */
        public void SetWater(float water)
        {
            this.Water = water;
        }

        /**
         *
         * Balığı görebilir miyim?
         *
         
         *
         */
        public bool CanSeeTheCreature(MultiplayerCreatureItem creature, bool longDistance = false)
        {
            return this.Position.Distance(creature.Position) < creature.Data.GetVisibilityDistance(longDistance);
        }

        /**
         *
         * Oyuncuya veri gönderir.
         *
         
         *
         */
        public void SendPacket(NetworkPacket packet)
        {
            Server.SendPacket(this, packet);
        }

        /**
         *
         * Oyuncuya veri gönderir.
         *
         
         *
         */
        public void SendPacketToAllClient(NetworkPacket packet, bool checkConnected = false)
        {
            Server.SendPacketToAllClient(packet, checkConnected);
        }

        /**
         *
         * Oyuncuya veri gönderir.
         *
         
         *
         */
        public void SendPacketToOtherClients(NetworkPacket packet, bool checkConnected = false)
        {
            Server.SendPacketToOtherClients(this, packet, checkConnected);
        }

        /**
         *
         * Verileri diske yazar
         *
         
         *
         */
        public bool SaveToDisk()
        {
            lock (Server.Instance.Storages.Player.ProcessLock)
            {
                var data = NetworkTools.Serialize(this);
                if (data == null)
                {
                    Log.Error(string.Format("Player.SaveToDisk -> Error Code (0x01): {0}", this.UniqueId));
                    return false;
                }

                if (!data.IsValid())
                {
                    Log.Error(string.Format("Player.SaveToDisk -> Error Code (0x02): {0}", this.UniqueId));
                    return false;
                }

                return data.WriteToDisk(Server.Instance.Storages.Player.GetPlayerFilePath(this.UniqueId));
            }
        }
    }
}
