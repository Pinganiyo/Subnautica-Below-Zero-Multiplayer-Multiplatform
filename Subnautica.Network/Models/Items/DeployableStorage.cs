namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class DeployableStorage : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.None;
        /**
         *
         * IsSignProcess Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsSignProcess { get; set; }

        /**
         *
         * IsSignSelect Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public bool IsSignSelect { get; set; }

        /**
         *
         * IsAdded Değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsAdded { get; set; }


        /**
         *
         * SignText Değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public string SignText { get; set; }

        /**
         *
         * SignColorIndex Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public int SignColorIndex { get; set; }

        /**
         *
         * WorldPickupItem Değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public WorldPickupItem WorldPickupItem { get; set; }
    }
}