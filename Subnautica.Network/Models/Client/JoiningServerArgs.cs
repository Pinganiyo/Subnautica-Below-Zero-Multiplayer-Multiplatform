namespace Subnautica.Network.Models.Client
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.Construction;
    using Subnautica.Network.Models.Storage.Player;
    using Subnautica.Network.Models.Storage.Story.StoryGoals;
    using Subnautica.Network.Models.Storage.Technology;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    using Metadata       = Subnautica.Network.Models.Metadata;
    using StoryStorage   = Subnautica.Network.Models.Storage.Story;
    using WorldChildrens = Subnautica.Network.Models.Storage.World.Childrens;

    [MessagePackObject]
    public class JoiningServerArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.JoiningServer;
        
        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.Startup;

        /**
         *
         * Benzersiz Oyuncu Id
         *
         
         *
         */
        [Key(5)]
        public string PlayerUniqueId { get; set; }

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        [Key(6)]
        public string PlayerSubRootId { get; set; }       

        /**
         *
         * Sunucu Id numarası
         *
         
         *
         */
        [Key(7)]
        public string ServerId { get; set; }

        /**
         *
         * Mevcut Sağlık
         *
         
         *
         */
        [Key(8)]
        public float PlayerHealth { get; set; }

        /**
         *
         * Su Miktarı
         *
         
         *
         */
        [Key(9)]
        public float PlayerWater { get; set; }

        /**
         *
         * Açlık Miktarı
         *
         
         *
         */
        [Key(10)]
        public float PlayerFood { get; set; }

        /**
         *
         * Oyuncu Konumu
         *
         
         *
         */
        [Key(11)]
        public ZeroVector3 PlayerPosition { get; set; }

        /**
         *
         * Oyuncu Açısı
         *
         
         *
         */
        [Key(12)]
        public ZeroQuaternion PlayerRotation { get; set; }

        /**
         *
         * Envanter eşyaları Açısı
         *
         
         *
         */
        [Key(13)]
        public Metadata.StorageContainer PlayerInventoryItems { get; set; }

        /**
         *
         * Ekipman eşyaları
         *
         
         *
         */
        [Key(14)]
        public byte[] PlayerEquipments { get; set; }

        /**
         *
         * Ekipman eşyala Id'leri
         *
         
         *
         */
        [Key(15)]
        public Dictionary<string, string> PlayerEquipmentSlots { get; set; }

        /**
         *
         * Hızlı slot id'leri
         *
         
         *
         */
        [Key(16)]
        public string[] PlayerQuickSlots { get; set; }

        /**
         *
         * Aktif slot değeri
         *
         
         *
         */
        [Key(17)]
        public int PlayerActiveSlot { get; set; }

        /**
         *
         * Teknoloji pinlerini barındırır.
         *
         
         *
         */
        [Key(18)]
        public List<TechType> PlayerItemPins { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        [Key(19)]
        public HashSet<NotificationItem> PlayerNotifications { get; set; }

        /**
         *
         * Açılmış teknolojileri barındırır.
         *
         
         *
         */
        [Key(20)]
        public Dictionary<TechType, TechnologyItem> Technologies { get; set; } = new Dictionary<TechType, TechnologyItem>();

        /**
         *
         * Taranmış teknolojileri barındırır.
         *
         
         *
         */
        [Key(21)]
        public HashSet<TechType> ScannedTechnologies { get; set; } = new HashSet<TechType>();

        /**
         *
         * Analiz edilmiş teknolojileri ekler.
         *
         
         *
         */
        [Key(22)]
        public HashSet<TechType> AnalizedTechnologies { get; set; } = new HashSet<TechType>();

        /**
         *
         * Açılmış ansiklopedileri barındırır.
         *
         
         *
         */
        [Key(23)]
        public HashSet<string> Encyclopedias { get; set; } = new HashSet<string>();

        /**
         *
         * Kullanılan araçları barındırır.
         *
         
         *
         */
        [Key(24)]
        public HashSet<TechType> PlayerUsedTools { get; set; } = new HashSet<TechType>();

        /**
         *
         * Dünya Yapılarını barındırır.
         *
         
         *
         */
        [Key(25)]
        public HashSet<ConstructionItem> Constructions { get; set; } = new HashSet<ConstructionItem>();

        /**
         *
         * Dünya Yapılarını barındırır.
         *
         
         *
         */
        [Key(26)]
        public byte[] ConstructionRoot { get; set; }

        /**
         *
         * Açılan şarkıları barındırır.
         *
         
         *
         */
        [Key(27)]
        public List<string> JukeboxDisks { get; set; }

        /**
         *
         * Bloklu listeyi barındırır.
         *
         
         *
         */
        [Key(28)]
        public Dictionary<string, string> InteractList { get; set; }

        /**
         *
         * Sunucu saatini barındırır.
         *
         
         *
         */
        [Key(29)]
        public float ServerTime { get; set; }

        /**
         *
         * İlk Giriş Mi?
         *
         
         *
         */
        [Key(30)]
        public bool IsFirstLogin { get; set; }

        /**
         *
         * Oyun Modu
         *
         
         *
         */
        [Key(31)]
        public GameModePresetId GameMode { get; set; }
        
        /**
         *
         * Bağlı oyuncu listesini döner.
         *
         
         *
         */
        [Key(32)]
        public List<PlayerItem> Players { get; set; }

        /**
         *
         * Doğmayacak Nesneler
         *
         
         *
         */
        [Key(33)]
        public Dictionary<string, NetworkWorldEntityComponent> PersistentEntities { get; set; }

        /**
         *
         * Dünya Nesneleri
         *
         
         *
         */
        [Key(34)]
        public HashSet<WorldDynamicEntity> DynamicEntities { get; set; }

        /**
         *
         * PlayerTimeLastSleep Değeri
         *
         
         *
         */
        [Key(35)]
        public float PlayerTimeLastSleep { get; set; }

        /**
         *
         * IsStartedGame Değeri
         *
         
         *
         */
        [Key(36)]
        public bool IsStartedGame { get; set; }

        /**
         *
         * SupplyDrops Değeri
         *
         
         *
         */
        [Key(37)]
        public List<WorldChildrens.SupplyDrop> SupplyDrops { get; set; }

        /**
         *
         * PlayerInteriorId Değeri
         *
         
         *
         */
        [Key(38)]
        public string PlayerInteriorId { get; set; }

        /**
         *
         * Bases Değeri
         *
         
         *
         */
        [Key(39)]
        public List<Base> Bases { get; set; }

        /**
         *
         * QuantumLocker Değeri
         *
         
         *
         */
        [Key(40)]
        public Metadata.StorageContainer QuantumLocker { get; set; }

        /**
         *
         * PlayerId Değeri
         *
         
         *
         */
        [Key(41)]
        public byte PlayerId { get; set; }

        /**
         *
         * MaxPlayerCount Değeri
         *
         
         *
         */
        [Key(42)]
        public byte MaxPlayerCount { get; set; }

        /**
         *
         * SeaTruckConnections Değeri
         *
         
         *
         */
        [Key(43)]
        public Dictionary<string, string> SeaTruckConnections { get; set; }

        /**
         *
         * Story Değeri
         *
         
         *
         */
        [Key(44)]
        public StoryStorage.Story Story { get; set; }

        /**
         *
         * ActivatedTeleporters Değeri
         *
         
         *
         */
        [Key(45)]
        public List<string> ActivatedTeleporters { get; set; }

        /**
         *
         * Kişiye özel hedefleri barındırır.
         *
         
         *
         */
        [Key(46)]
        public HashSet<ZeroStoryGoal> PlayerSpecialGoals { get; set; }

        /**
         *
         * Brinicles barındırır.
         *
         
         *
         */
        [Key(47)]
        public HashSet<Brinicle> Brinicles { get; set; }

        /**
         *
         * CosmeticItems Değeri
         *
         
         *
         */
        [Key(48)]
        public HashSet<CosmeticItem> CosmeticItems { get; set; }

        /**
         *
         * DiscoveredTechTypes Değeri
         *
         
         *
         */
        [Key(49)]
        public HashSet<TechType> DiscoveredTechTypes { get; set; } = new HashSet<TechType>();

        /**
         *
         * PlayerRespawnPointId Değeri
         *
         
         *
         */
        [Key(50)]
        public string PlayerRespawnPointId { get; set; }

        /**
         *
         * IsInitialEquipmentAdded Değeri
         *
         
         *
         */
        [Key(51)]
        public bool IsInitialEquipmentAdded { get; set; }

        /**
         *
         * PlayerHypnotizeTime Değeri
         *
         
         *
         */
        [Key(52)]
        public float PlayerHypnotizeTime { get; set; }
    }
}