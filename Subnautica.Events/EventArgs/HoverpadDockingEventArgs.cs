namespace Subnautica.Events.EventArgs
{
    using System;

    public class HoverpadDockingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public HoverpadDockingEventArgs(string uniqueId, string itemId, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.ItemId    = itemId;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * ItemId Değerini barındırır.
         *
         
         *
         */
        public string ItemId { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
