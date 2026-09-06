namespace Subnautica.Events.EventArgs
{
    using System;

    public class StorageItemRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StorageItemRemovedEventArgs(string constructionId, TechType techType, string itemId, Pickupable item)
        {
            this.ConstructionId = constructionId;
            this.TechType       = techType;
            this.ItemId         = itemId;
            this.Item           = item;
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
    }
}
