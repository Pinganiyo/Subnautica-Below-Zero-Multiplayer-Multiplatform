namespace Subnautica.Events.EventArgs
{
    using System;

    public class ChargerItemRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ChargerItemRemovedEventArgs(string constructionId, string slotId, TechType techType, string itemId, Pickupable item)
        {
            this.ConstructionId = constructionId;
            this.SlotId         = slotId;
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
         * SlotId değeri
         *
         
         *
         */
        public string SlotId { get; set; }

        /**
         *
         * TechType değeri
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
