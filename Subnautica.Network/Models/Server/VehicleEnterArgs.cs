namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class VehicleEnterArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleEnter;

        /**
         *
         * CustomId Değeri
         *
         
         *
         */
        [Key(5)]
        public string CustomId { get; set; }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(6)]
        public string UniqueId { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        [Key(7)]
        public TechType TechType { get; set; }

        /**
         *
         * Position Değeri
         *
         
         *
         */
        [Key(8)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation Değeri
         *
         
         *
         */
        [Key(9)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Health Değeri
         *
         
         *
         */
        [Key(10)]
        public float Health { get; set; }

        /**
         *
         * Vehicle Değeri
         *
         
         *
         */
        [Key(11)]
        public WorldDynamicEntity Vehicle { get; set; }
    }
}