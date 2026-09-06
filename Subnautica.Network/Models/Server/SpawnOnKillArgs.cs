namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class SpawnOnKillArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SpawnOnKill;

        /**
         *
         * WorldPickupItem Değeri
         *
         
         *
         */
        [Key(5)]
        public WorldPickupItem WorldPickupItem { get; set; }

        /**
         *
         * Entity Değeri
         *
         
         *
         */
        [Key(6)]
        public WorldDynamicEntity Entity { get; set; }
    }
}
