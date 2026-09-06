namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class TechnologyFragmentAddedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.TechnologyFragmentAdded;

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
         * TechType Değeri
         *
         
         *
         */
        [Key(6)]
        public TechType TechType { get; set; }

        /**
         *
         * Unlocked Değeri
         *
         
         *
         */
        [Key(7)]
        public int Unlocked { get; set; }

        /**
         *
         * TotalFragment Değeri
         *
         
         *
         */
        [Key(8)]
        public int TotalFragment { get; set; }
    }
}
