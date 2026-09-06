namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Structures;

    using EntityModel = Subnautica.Network.Models.WorldEntity;
    
    [MessagePackObject]
    public class ExosuitDrillArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ExosuitDrill;

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(6)]
        public string SlotId { get; set; }

        /**
         *
         * MaxHealth Değeri
         *
         
         *
         */
        [Key(7)]
        public float MaxHealth { get; set; }

        /**
         *
         * NewHealth Değeri
         *
         
         *
         */
        [Key(8)]
        public float NewHealth { get; set; }

        /**
         *
         * DropTechType Değeri
         *
         
         *
         */
        [Key(9)]
        public TechType DropTechType { get; set; }

        /**
         *
         * DropPositions Değeri
         *
         
         *
         */
        [Key(10)]
        public List<ZeroVector3> DropPositions { get; set; }

        /**
         *
         * InventoryItems Değeri
         *
         
         *
         */
        [Key(11)]
        public List<WorldPickupItem> InventoryItems { get; set; } = new List<WorldPickupItem>();

        /**
         *
         * WorldItems Değeri
         *
         
         *
         */
        [Key(12)]
        public List<WorldDynamicEntity> WorldItems { get; set; } = new List<WorldDynamicEntity>();

        /**
         *
         * DisableItem Değeri
         *
         
         *
         */
        [Key(13)]
        public WorldPickupItem DisableItem { get; set; }

        /**
         *
         * IsMultipleDrill Değeri
         *
         
         *
         */
        [Key(14)]
        public bool IsMultipleDrill { get; set; }

        /**
         *
         * IsStaticWorldEntity Değeri
         *
         
         *
         */
        [Key(15)]
        public bool IsStaticWorldEntity { get; set; }

        /**
         *
         * StaticEntity Değeri
         *
         
         *
         */
        [Key(16)]
        public EntityModel.Drillable StaticEntity { get; set; }
    }
}