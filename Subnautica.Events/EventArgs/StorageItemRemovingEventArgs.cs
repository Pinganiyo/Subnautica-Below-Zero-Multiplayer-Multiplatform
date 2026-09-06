namespace Subnautica.Events.EventArgs
{
    using System;

    public class StorageItemRemovingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StorageItemRemovingEventArgs(string uniqueId, TechType techType, string itemId, Pickupable item, bool IsAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.TechType  = techType;
            this.ItemId    = itemId;
            this.Item      = item;
            this.IsAllowed = IsAllowed;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

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
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
