namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrafterEndedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrafterEndedEventArgs(string uniqueId, TechType crafterTechType, TechType techType, global::GhostCrafter crafter)
        {
            this.UniqueId        = uniqueId;
            this.CrafterTechType = crafterTechType;
            this.TechType        = techType;
            this.Crafter         = crafter;
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
         * CrafterTechType Değerini barındırır.
         *
         
         *
         */
        public TechType CrafterTechType { get; set; }

        /**
         *
         * TechType Değerini barındırır.
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * Crafter Değerini barındırır.
         *
         
         *
         */
        public global::GhostCrafter Crafter { get; set; }
    }
}
