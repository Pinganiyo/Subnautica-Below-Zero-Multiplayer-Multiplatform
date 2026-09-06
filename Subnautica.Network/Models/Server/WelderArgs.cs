namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class WelderArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.WelderRepair;

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
         * TechType değeri
         *
         
         *
         */
        [Key(6)]
        public TechType TechType { get; set; }

        /**
         *
         * Health değeri
         *
         
         *
         */
        [Key(7)]
        public float Health { get; set; }
    }
}