namespace Subnautica.Network.Models.Metadata
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Charger : MetadataComponent
    {
        /**
         *
         * IsOpening Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsOpening { get; set; } = false;

        /**
         *
         * IsRemoving Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool IsRemoving { get; set; } = false;

        /**
         *
         * IsClosing Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsClosing { get; set; } = false;

        /**
         *
         * Items Değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public List<BatteryItem> Items { get; set; } = new List<BatteryItem>();
    }

    [MessagePackObject]
    public class ChargerSimple
    {
        /**
         *
         * Yapı Id Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public uint ConstructionId { get; set; }

        /**
         *
         * IsPowered Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool IsPowered { get; set; }

        /**
         *
         * IsCharging Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsCharging { get; set; }

        /**
         *
         * Batteries Değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public float[] Batteries { get; set; }

        /**
         *
         * Items Değerini barındırır.
         *
         
         *
         */
        [IgnoreMember]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ChargerSimple()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ChargerSimple(uint constructionId, float[] items, bool isPowered, ZeroVector3 position)
        {
            this.ConstructionId = constructionId;
            this.Batteries      = items;
            this.IsPowered      = isPowered;
            this.Position       = position;
        }
    }
}
