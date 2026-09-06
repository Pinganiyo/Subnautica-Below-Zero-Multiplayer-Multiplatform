namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class MetalDetector : NetworkPlayerItemComponent
    {
        /**
         *
         * TechTypeIndex değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public TechType TechTypeIndex { get; set; }

        /**
         *
         * TechTypeIndex değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public global::MetalDetector.ScreenState ScreenState { get; set; }

        /**
         *
         * IsUsing değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsUsing { get; set; }

        /**
         *
         * Wiggle değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public float Wiggle { get; set; }
    }
}