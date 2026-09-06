namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class EnergyMixinTransmissionArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.EnergyMixinTransmission;

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
        public List<EnergyMixinTransmissionItem> Items { get; set; }
    }

    [MessagePackObject]
    public class EnergyMixinTransmissionItem
    {
        /**
         *
         * VehicleId değeri
         *
         
         *
         */
        [Key(0)]
        public ushort ItemId { get; set; }

        /**
         *
         * Charge değeri
         *
         
         *
         */
        [Key(1)]
        public float Charge { get; set; }

        /**
         *
         * Position değeri
         *
         
         *
         */
        [IgnoreMember]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Sınıf Ayarlarını yapar.
         *
         
         *
         */
        public EnergyMixinTransmissionItem()
        {

        }

        /**
         *
         * Sınıf Ayarlarını yapar.
         *
         
         *
         */
        public EnergyMixinTransmissionItem(ushort itemId, float charge, ZeroVector3 position)
        {
            this.ItemId   = itemId;
            this.Charge   = charge;
            this.Position = position;
        }
    }
}