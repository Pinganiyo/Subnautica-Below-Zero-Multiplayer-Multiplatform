namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class PipeSurfaceFloater : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.PipeSurfaceFloater;

        /**
         *
         * ProcessType Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public byte ProcessType { get; set; }

        /**
         *
         * PipeId Değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public string PipeId { get; set; }

        /**
         *
         * ParentId Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public string ParentId { get; set; }

        /**
         *
         * Position Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation Değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Entity Değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public WorldDynamicEntity Entity { get; set; }

        /**
         *
         * PickupItem Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public WorldPickupItem PickupItem { get; set; }

        /**
         *
         * IsSurfaceFloaterDeploy kontrolü yapar.
         *
         
         *
         */
        public bool IsSurfaceFloaterDeploy()
        {
            return this.ProcessType == 1;
        }

        /**
         *
         * IsOxygenPipePlace kontrolü yapar.
         *
         
         *
         */
        public bool IsOxygenPipePlace()
        {
            return this.ProcessType == 3;
        }

        /**
         *
         * IsOxygenPipePickup kontrolü yapar.
         *
         
         *
         */
        public bool IsOxygenPipePickup()
        {
            return this.ProcessType == 4;
        }
    }
}