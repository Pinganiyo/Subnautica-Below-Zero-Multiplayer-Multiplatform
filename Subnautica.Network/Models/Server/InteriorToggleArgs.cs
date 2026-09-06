namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class InteriorToggleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.InteriorToggle;

        /**
         *
         * InteriorId Değeri
         *
         
         *
         */
        [Key(5)]
        public string InteriorId { get; set; }

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