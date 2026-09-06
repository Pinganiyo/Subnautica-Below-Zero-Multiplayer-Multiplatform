namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents
{
    using System;

    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class SeaTruckTeleportationModule : NetworkDynamicEntityComponent
    {
        /**
         *
         * LiveMixin Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public LiveMixin LiveMixin { get; set; } = new LiveMixin(500f, 500f);
        
        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public SeaTruckTeleportationModule Initialize(Action<NetworkDynamicEntityComponent> onEntityComponentInitialized)
        {
            onEntityComponentInitialized?.Invoke(this);
            return this;
        }
    }
}

