namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class ExosuitJumpArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ExosuitJump;

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }
    }
}