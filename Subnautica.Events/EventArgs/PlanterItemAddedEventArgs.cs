namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlanterItemAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlanterItemAddedEventArgs(string uniqueId, string itemId, Plantable plantable, int slotId)
        {
            this.UniqueId  = uniqueId;
            this.ItemId    = itemId;
            this.Plantable = plantable;
            this.SlotId    = slotId;
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
         * Side Değerini barındırır.
         *
         
         *
         */
        public string ItemId { get; set; }

        /**
         *
         * Plantable Değeri
         *
         
         *
         */
        public Plantable Plantable { get; set; }

        /**
         *
         * SlotId Değeri
         *
         
         *
         */
        public int SlotId { get; set; }
    }
}
