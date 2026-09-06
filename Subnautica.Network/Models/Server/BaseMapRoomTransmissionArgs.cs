namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using LiteNetLib;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class BaseMapRoomTransmissionArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.BaseMapRoomTransmission;

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
         * Packet Teslim Türü
         *
         
         *
         */
        [Key(2)]
        public override DeliveryMethod DeliveryMethod { get; set; } = DeliveryMethod.ReliableSequenced;

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
         * UniqueId Değerini Barındırır.
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * Items Değerini Barındırır.
         *
         
         *
         */
        [Key(6)]
        public List<BaseMapRoomTransmissionItem> Items { get; set; }
    }

    [MessagePackObject]
    public class BaseMapRoomTransmissionItem
    {
        /**
         *
         * Health Değerini Barındırır.
         *
         
         *
         */
        [Key(0)]
        public string UniqueId { get; set; }

        /**
         *
         * Charge Değerini Barındırır.
         *
         
         *
         */
        [Key(1)]
        public long Position { get; set; }

        /**
         *
         * Sınıf ayarlarını yapar.
         *
         
         *
         */
        public BaseMapRoomTransmissionItem()
        {

        }

        /**
         *
         * Sınıf ayarlarını yapar.
         *
         
         *
         */
        public BaseMapRoomTransmissionItem(string uniqueId, long position)
        {
            this.UniqueId = uniqueId;
            this.Position = position;
        }
    }
}
