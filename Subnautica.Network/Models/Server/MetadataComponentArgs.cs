namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class MetadataComponentArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.MetadataRequest;

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
         * UniqueId verisi
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * IsStartupNull verisi
         *
         
         *
         */
        [Key(6)]
        public bool IsStartupNull { get; set; }

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
         * SecretTechType Değeri
         *
         
         *
         */
        [Key(8)]
        public TechType SecretTechType { get; set; }

        /**
         *
         * Metadata verisi
         *
         
         *
         */
        [Key(9)]
        public MetadataComponent Component { get; set; }
    }
}