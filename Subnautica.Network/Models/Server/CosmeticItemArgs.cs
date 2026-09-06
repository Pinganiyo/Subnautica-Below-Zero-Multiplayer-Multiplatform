namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class CosmeticItemArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.CosmeticItem;

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
         * BaseId Değeri
         *
         
         *
         */
        [Key(6)]
        public string BaseId { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        [Key(7)]
        public TechType TechType { get; set; }

        /**
         *
         * Position Değeri
         *
         
         *
         */
        [Key(8)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation Değeri
         *
         
         *
         */
        [Key(9)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * PickupItem Değeri
         *
         
         *
         */
        [Key(10)]
        public WorldPickupItem PickupItem { get; set; }

        /**
         *
         * CosmeticItem Değeri
         *
         
         *
         */
        [Key(11)]
        public CosmeticItem CosmeticItem { get; set; }
    }
}