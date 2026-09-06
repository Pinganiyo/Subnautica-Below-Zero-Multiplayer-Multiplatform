namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class EntitySlotProcessArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.EntitySlotProcess;

        /**
         *
         * IsBreakable Değeri
         *
         
         *
         */
        [Key(5)]
        public bool IsBreakable { get; set; }

        /**
         *
         * ZeroVector3 Değeri
         *
         
         *
         */
        [Key(6)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Entity Değeri
         *
         
         *
         */
        [Key(7)]
        public WorldDynamicEntity Entity { get; set; }

        /**
         *
         * WorldPickupItem Değeri
         *
         
         *
         */
        [Key(8)]
        public WorldPickupItem WorldPickupItem { get; set; }
    }
}