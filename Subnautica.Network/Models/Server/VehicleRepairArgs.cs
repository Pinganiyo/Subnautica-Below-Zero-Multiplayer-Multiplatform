namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class VehicleRepairArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleRepair;

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(5)]
        public List<VehicleRepairItem> Repairs { get; set; } = new List<VehicleRepairItem>();
    }

    [MessagePackObject]
    public class VehicleRepairItem
    {
        /**
         *
         * VehicleId değeri
         *
         
         *
         */
        [Key(0)]
        public string VehicleId { get; set; }

        /**
         *
         * VehicleId değeri
         *
         
         *
         */
        [Key(1)]
        public float Health { get; set; }

        /**
         *
         * Sınıf Ayarlarını yapar.
         *
         
         *
         */
        public VehicleRepairItem()
        {

        }

        /**
         *
         * Sınıf Ayarlarını yapar.
         *
         
         *
         */
        public VehicleRepairItem(string vehicleId, float health)
        {
            this.VehicleId = vehicleId;
            this.Health    = health;
        }
    }
}