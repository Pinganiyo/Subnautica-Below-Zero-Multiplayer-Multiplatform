namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class SubrootToggleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SubrootToggle;

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        [Key(5)]
        public string SubrootId { get; set; }

        /**
         *
         * IsEntered Değeri
         *
         
         *
         */
        [Key(6)]
        public bool IsEntered { get; set; }
    }
}