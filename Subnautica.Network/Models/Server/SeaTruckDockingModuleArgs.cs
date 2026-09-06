namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class SeaTruckDockingModuleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SeaTruckDockingModule;

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * VehicleId Değeri
         *
         
         *
         */
        [Key(6)]
        public string VehicleId { get; set; }

        /**
         *
         * Vehicle Değeri
         *
         
         *
         */
        [Key(7)]
        public WorldDynamicEntity Vehicle { get; set; }

        /**
         *
         * IsDocking Değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsDocking { get; set; }

        /**
         *
         * IsEnterUndock Değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsEnterUndock { get; set; }

        /**
         *
         * IsEnterUndock Değeri
         *
         
         *
         */
        [Key(10)]
        public ZeroVector3 UndockPosition { get; set; }

        /**
         *
         * IsEnterUndock Değeri
         *
         
         *
         */
        [Key(11)]
        public ZeroQuaternion UndockRotation { get; set; }
    }
}