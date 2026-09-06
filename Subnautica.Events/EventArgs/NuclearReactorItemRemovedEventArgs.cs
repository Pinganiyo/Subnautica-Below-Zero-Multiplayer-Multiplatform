namespace Subnautica.Events.EventArgs
{
    using System;

    public class NuclearReactorItemRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public NuclearReactorItemRemovedEventArgs(string constructionId, string slotId, string itemId, Pickupable item)
        {
            this.ConstructionId = constructionId;
            this.SlotId = slotId;
            this.ItemId = itemId;
            this.Item = item;
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
         * SlotId değeri
         *
         
         *
         */
        public string SlotId { get; set; }

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
