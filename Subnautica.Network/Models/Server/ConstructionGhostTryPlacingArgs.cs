namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Construction.Shared;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class ConstructionGhostTryPlacingArgs : NetworkPacket
    {        
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ConstructingGhostTryPlacing;
        
        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.Construction;

        /**
         *
         * Packet Kanal Id
         *
         
         *
         */
        [Key(3)]
        public override byte ChannelId { get; set; } = 1;

        /**
         *
         * Ağ Kimliği Pozisyonu
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        [Key(6)]
        public string SubrootId { get; set; }

        /**
         *
         * Nesne Türü
         *
         
         *
         */
        [Key(7)]
        public TechType TechType { get; set; }

        /**
         *
         * Nesne Türü
         *
         
         *
         */
        [Key(8)]
        public int LastRotation { get; set; }

        /**
         *
         * Nesne Pozisyonu
         *
         
         *
         */
        [Key(9)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Nesne Açısı
         *
         
         *
         */
        [Key(10)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * AimTransform
         *
         
         *
         */
        [Key(11)]
        public ZeroTransform AimTransform { get; set; }

        /**
         *
         * BaseGhostComponent
         *
         
         *
         */
        [Key(12)]
        public BaseGhostComponent BaseGhostComponent { get; set; }

        /**
         *
         * IsCanPlace Değeri
         *
         
         *
         */
        [Key(13)]
        public bool IsCanPlace { get; set; }

        /**
         *
         * IsBasePiece Değeri
         *
         
         *
         */
        [Key(14)]
        public bool IsBasePiece { get; set; }

        /**
         *
         * IsError Değeri
         *
         
         *
         */
        [Key(15)]
        public bool IsError { get; set; }
    }
}
