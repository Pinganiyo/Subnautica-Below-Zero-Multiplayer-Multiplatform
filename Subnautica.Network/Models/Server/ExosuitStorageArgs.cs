namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class ExosuitStorageArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ExosuitStorage;

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
         * IsAdded Değeri
         *
         
         *
         */
        [Key(6)]
        public bool IsAdded { get; set; }

        /**
         *
         * IsPickup Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsPickup { get; set; }

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