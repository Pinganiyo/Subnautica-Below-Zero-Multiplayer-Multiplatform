namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class PrecursorTeleporterArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.PrecursorTeleporter;

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
         * TeleporterId değeri
         *
         
         *
         */
        [Key(6)]
        public string TeleporterId { get; set; }

        /**
         *
         * IsTerminal değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsTerminal { get; set; }

        /**
         *
         * IsTeleportStart değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsTeleportStart { get; set; }

        /**
         *
         * IsTeleportCompleted değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsTeleportCompleted { get; set; }
    }
}