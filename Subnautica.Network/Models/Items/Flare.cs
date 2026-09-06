namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Flare : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.Flare;

        /**
         *
         * Position değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Forward değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public ZeroVector3 Forward { get; set; }
        /**
         *
         * Rotation değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public ZeroQuaternion Rotation { get; set; }
        /**
         *
         * Intensity değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public float Intensity { get; set; }

        /**
         *
         * Range değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public float Range { get; set; }

        /**
         *
         * Energy değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public float Energy { get; set; }

        /**
         *
         * Entity Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public WorldDynamicEntity Entity { get; set; }
    }
}