
namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Construction.Shared;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class ConstructionGhostMovingArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ConstructingGhostMoving;
        
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
         * Nesne Türü
         *
         
         *
         */
        [Key(5)]
        public TechType TechType { get; set; }

        /**
         *
         * Ağ Kimliği Pozisyonu
         *
         
         *
         */
        [Key(6)]
        public string UniqueId { get; set; }

        /**
         *
         * Nesne Pozisyonu
         *
         
         *
         */
        [Key(7)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Nesne Açısı
         *
         
         *
         */
        [Key(8)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * ZeroTransform
         *
         
         *
         */
        [Key(9)]
        public ZeroTransform AimTransform { get; set; }

        /**
         *
         * BaseGhostComponent
         *
         
         *
         */
        [Key(10)]
        public BaseGhostComponent BaseGhostComponent { get; set; }

        /**
         *
         * IsCanPlace Değeri
         *
         
         *
         */
        [Key(11)]
        public bool IsCanPlace { get; set; }

        /**
         *
         * UpdatePlacement Değeri
         *
         
         *
         */
        [Key(12)]
        public bool UpdatePlacement { get; set; }

        /**
         *
         * LastRotation Değeri
         *
         
         *
         */
        [Key(13)]
        public int LastRotation { get; set; }
    }
}