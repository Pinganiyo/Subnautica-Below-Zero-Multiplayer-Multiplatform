namespace Subnautica.Network.Models.Items
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class SpyPenguin : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.SpyPenguin;

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
         * Name Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public string Name { get; set; }

        /**
         *
         * Items Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public float Health { get; set; }

        /**
         *
         * Items Değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public List<byte[]> Items { get; set; }

        /**
         *
         * StalkerChance Değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public float SpawnChance { get; set; } = -1f;

        /**
         *
         * WorldPickupItem Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public WorldPickupItem WorldPickupItem { get; set; }

        /**
         *
         * Entity Değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public WorldDynamicEntity Entity { get; set; }

        /**
         *
         * IsPickup Değerini barındırır.
         *
         
         *
         */
        [Key(10)]
        public bool IsPickup { get; set; }

        /**
         *
         * IsStalkerFur Değerini barındırır.
         *
         
         *
         */
        [Key(11)]
        public bool IsStalkerFur { get; set; }

        /**
         *
         * IsDeploy Değerini barındırır.
         *
         
         *
         */
        [Key(12)]
        public bool IsDeploy { get; set; }

        /**
         *
         * IsAdded Değerini barındırır.
         *
         
         *
         */
        [Key(13)]
        public bool IsAdded { get; set; }
    }
}