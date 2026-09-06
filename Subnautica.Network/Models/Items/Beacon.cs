namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Beacon : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.Beacon;

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
         * IsDeployedOnLand Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsDeployedOnLand { get; set; }

        /**
         *
         * Text Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public string Text { get; set; }

        /**
         *
         * IsTextChanged Değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsTextChanged { get; set; }

        /**
         *
         * Entity Değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public WorldDynamicEntity Entity { get; set; }
    }
}