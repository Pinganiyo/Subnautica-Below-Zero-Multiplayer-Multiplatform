namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    using System.Collections.Generic;

    [MessagePackObject]
    public class DeconstructionBeginArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.DeconstructionBegin;
        
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
         * Yapı Id Kimliği Pozisyonu
         *
         
         *
         */
        [Key(5)]
        public uint Id { get; set; }

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
         * IsFailed Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsFailed { get; set; }
    }
}
