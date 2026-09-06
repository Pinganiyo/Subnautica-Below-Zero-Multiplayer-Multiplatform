namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Welder : NetworkPlayerItemComponent
    {
        /**
         *
         * IsActivated değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsActivated { get; set; }
    }
}