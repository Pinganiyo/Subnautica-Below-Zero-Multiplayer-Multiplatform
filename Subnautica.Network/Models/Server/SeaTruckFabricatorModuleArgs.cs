namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class SeaTruckFabricatorModuleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SeaTruckFabricatorModule;

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
         * WorldPickupItem Değeri
         *
         
         *
         */
        [Key(6)]
        public WorldPickupItem WorldPickupItem { get; set; }

        /**
         *
         * IsSignProcess Değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public bool IsSignProcess { get; set; }

        /**
         *
         * IsSignSelect Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public bool IsSignSelect { get; set; }

        /**
         *
         * IsAdded Değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public bool IsAdded { get; set; }

        /**
         *
         * SignText Değerini barındırır.
         *
         
         *
         */
        [Key(10)]
        public string SignText { get; set; }

        /**
         *
         * SignColorIndex Değerini barındırır.
         *
         
         *
         */
        [Key(11)]
        public int SignColorIndex { get; set; }
    }
}