namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class PlayerItemActionArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.PlayerItemAction;

        /**
         *
         * Nesne Türü
         *
         
         *
         */
        [Key(5)]
        public NetworkPlayerItemComponent Item { get; set; }
    }
}
