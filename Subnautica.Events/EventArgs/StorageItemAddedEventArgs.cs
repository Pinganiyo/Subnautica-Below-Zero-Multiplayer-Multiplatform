namespace Subnautica.Events.EventArgs
{
    using System;

    public class StorageItemAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StorageItemAddedEventArgs(string constructionId, TechType techType, string itemId, Pickupable item, InventoryItem inventoryItem)
        {
            this.ConstructionId = constructionId;
            this.TechType       = techType;
            this.ItemId         = itemId;
            this.Item           = item;
            this.InventoryItem  = inventoryItem;
        }

        /**
         *
         * ConstructionId değeri
         *
         
         *
         */
        public string ConstructionId { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * ItemId değeri
         *
         
         *
         */
        public string ItemId { get; set; }

        /**
         *
         * Item Değeri
         *
         
         *
         */
        public Pickupable Item { get; set; }

        /**
         *
         * InventoryItem Değeri
         *
         
         *
         */
        public InventoryItem InventoryItem { get; set; }
    }
}
