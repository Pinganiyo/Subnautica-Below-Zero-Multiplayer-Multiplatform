namespace Subnautica.Events.EventArgs
{
    using System;

    public class InventoryItemAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public InventoryItemAddedEventArgs(string uniqueId, Pickupable item)
        {
            this.UniqueId = uniqueId;
            this.Item     = item;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Item Değerini barındırır.
         *
         
         *
         */
        public Pickupable Item { get; set; }
    }
}
