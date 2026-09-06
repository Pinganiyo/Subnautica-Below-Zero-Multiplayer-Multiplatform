namespace Subnautica.Events.EventArgs
{
    using System;

    public class InventoryItemRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public InventoryItemRemovedEventArgs(string uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }
    }
}
