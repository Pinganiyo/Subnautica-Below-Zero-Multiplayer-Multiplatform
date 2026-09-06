namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class ItemDropArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ItemDrop;

        /**
         *
         * Forward değeri
         *
         
         *
         */
        [Key(5)]
        public ZeroVector3 Forward { get; set; }

        /**
         *
         * WorldPickupItem değeri
         *
         
         *
         */
        [Key(6)]
        public WorldPickupItem WorldPickupItem { get; set; }

        /**
         *
         * Entity değeri
         *
         
         *
         */
        [Key(7)]
        public WorldDynamicEntity Entity { get; set; }
    }
}
