namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class SeaTruckAquariumModuleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SeaTruckAquariumModule;

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
         * WorldPickupItem Değeri
         *
         
         *
         */
        [Key(7)]
        public WorldPickupItem WorldPickupItem { get; set; }
    }
}