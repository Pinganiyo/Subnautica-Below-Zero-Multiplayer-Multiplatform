namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class StorageLocker : MetadataComponent
    {
        /**
         *
         * IsAdded Değeri
         *
         
         *
         */
        [Key(0)]
        public bool IsAdded { get; set; }

        /**
         *
         * WorldPickupItem Değeri
         *
         
         *
         */
        [Key(1)]
        public WorldPickupItem WorldPickupItem { get; set; }
    }
}