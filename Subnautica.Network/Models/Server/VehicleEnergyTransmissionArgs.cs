namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class VehicleEnergyTransmissionArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleEnergyTransmission;

        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.EnergyTransmission;

        /**
         *
         * PowerCells değeri
         *
         
         *
         */
        [Key(5)]
        public List<VehicleEnergyTransmissionItem> PowerCells { get; set; }
    }

    [MessagePackObject]
    public class VehicleEnergyTransmissionItem
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
        public float PowerCell1 { get; set; }

        /**
         *
         * VehicleId değeri
         *
         
         *
         */
        [Key(2)]
        public float PowerCell2 { get; set; }

        /**
         *
         * Sınıf Ayarlarını yapar.
         *
         
         *
         */
        public VehicleEnergyTransmissionItem()
        {

        }

        /**
         *
         * Sınıf Ayarlarını yapar.
         *
         
         *
         */
        public VehicleEnergyTransmissionItem(string vehicleId, float powerCell1, float powerCell2)
        {
            this.VehicleId  = vehicleId;
            this.PowerCell1 = powerCell1;
            this.PowerCell2 = powerCell2;
        }
    }
}