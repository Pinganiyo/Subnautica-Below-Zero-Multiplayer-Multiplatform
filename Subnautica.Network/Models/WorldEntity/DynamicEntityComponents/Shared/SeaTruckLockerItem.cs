namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared
{
    using MessagePack;

    [MessagePackObject]
    public class SeaTruckLockerItem
    {
        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(0)]
        public string UniqueId { get; set; }

        /**
         *
         * StorageContainer Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public Metadata.StorageContainer StorageContainer { get; set; }
    }
}
