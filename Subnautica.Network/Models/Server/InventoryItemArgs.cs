namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Metadata;

    [MessagePackObject]
    public class InventoryItemArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.InventoryItem;

        /**
         *
         * ItemId Nesnesi
         *
         
         *
         */
        [Key(5)]
        public string ItemId { get; set; }

        /**
         *
         * Item Nesnesi
         *
         
         *
         */
        [Key(6)]
        public StorageItem Item { get; set; }

        /**
         *
         * IsAdded Nesnesi
         *
         
         *
         */
        [Key(7)]
        public bool IsAdded { get; set; }
    }
}
