namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class SpyPenguin : NetworkDynamicEntityComponent
    {
        /**
         *
         * Lockers Değeri
         *
         
         *
         */
        [Key(0)]
        public Metadata.StorageContainer StorageContainer { get; set; } = Metadata.StorageContainer.Create(2, 2);

        /**
         *
         * Lockers Değeri
         *
         
         *
         */
        [Key(1)]
        public string Name { get; set; } = null;

        /**
         *
         * Health Değeri
         *
         
         *
         */
        [Key(2)]
        public LiveMixin LiveMixin { get; set; } = new LiveMixin(10f, 10f);
    }
}
