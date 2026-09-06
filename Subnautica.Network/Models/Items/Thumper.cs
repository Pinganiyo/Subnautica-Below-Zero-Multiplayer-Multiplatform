namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Thumper : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.Thumper;

        /**
         *
         * Position Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation Değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Charge Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public float Charge { get; set; }

        /**
         *
         * Entity Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public WorldDynamicEntity Entity { get; set; }
    }
}