namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class ConstructionAmountChangedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ConstructingAmountChanged;
        
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
         * IsConstruct Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsConstruct { get; set; }

        /**
         *
         * Amount Değeri
         *
         
         *
         */
        [Key(8)]
        public float Amount { get; set; }
    }
}
