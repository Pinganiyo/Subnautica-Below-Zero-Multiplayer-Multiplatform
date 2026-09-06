namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class UseableDiveHatchArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.UseableDiveHatch;

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
         * IsBulkHead Değeri
         *
         
         *
         */
        [Key(6)]
        public bool IsBulkHead { get; set; }

        /**
         *
         * IsLifePod Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsLifePod { get; set; }

        /**
         *
         * IsEnter Değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsEnter { get; set; }

        /**
         *
         * IsMoonpoolExpansion Değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsMoonpoolExpansion { get; set; }
    }
}
