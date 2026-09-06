namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Sign : MetadataComponent
    {
        /**
         *
         * Metni barındırır.
         *
         
         *
         */
        [Key(0)]
        public string Text { get; set; }

        /**
         *
         * ElementsState değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool[] ElementsState { get; set; }

        /**
         *
         * ScaleIndex değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public int ScaleIndex { get; set; }

        /**
         *
         * ColorIndex değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public int ColorIndex { get; set; }

        /**
         *
         * IsBackgroundEnabled değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsBackgroundEnabled { get; set; }

        /**
         *
         * IsOpening değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public bool IsOpening { get; set; }

        /**
         *
         * IsSave değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsSave { get; set; }
    }
}
