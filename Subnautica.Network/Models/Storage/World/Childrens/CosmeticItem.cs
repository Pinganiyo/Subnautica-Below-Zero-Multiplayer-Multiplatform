namespace Subnautica.Network.Models.Storage.World.Childrens
{
    using MessagePack;

    using Subnautica.Network.Models.Metadata;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class CosmeticItem
    {
        /**
         *
         * StorageItem değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public StorageItem StorageItem { get; set; }

        /**
         *
         * BaseId değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public string BaseId { get; set; }

        /**
         *
         * Mevcut değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public CosmeticItem()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public CosmeticItem(StorageItem storageItem, string baseId, ZeroVector3 position, ZeroQuaternion rotation)
        {
            this.StorageItem = storageItem;
            this.BaseId      = baseId;
            this.Position    = position;
            this.Rotation    = rotation;
        }
    }
}