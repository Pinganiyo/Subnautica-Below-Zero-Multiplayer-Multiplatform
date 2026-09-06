namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class VehicleBatteryArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleBattery;

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * BatterySlotId değeri
         *
         
         *
         */
        [Key(6)]
        public string BatterySlotId { get; set; }

        /**
         *
         * BatteryType değeri
         *
         
         *
         */
        [Key(7)]
        public TechType BatteryType { get; set; }

        /**
         *
         * IsOpening değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsOpening { get; set; }

        /**
         *
         * IsAdding değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsAdding { get; set; }

        /**
         *
         * Charge değeri
         *
         
         *
         */
        [Key(10)]
        public float Charge { get; set; }
    }
}