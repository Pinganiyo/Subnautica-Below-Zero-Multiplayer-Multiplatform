namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrafterItemPickupEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrafterItemPickupEventArgs(string uniqueId, global::GhostCrafter crafter, int amount, TechType fabricatorType, TechType techType, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.Crafter        = crafter;
            this.Amount         = amount;
            this.FabricatorType = fabricatorType;
            this.TechType       = techType;
            this.IsAllowed      = isAllowed;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * Crafter Değeri
         *
         
         *
         */
        public global::GhostCrafter Crafter { get; private set; }

        /**
         *
         * amount Değeri
         *
         
         *
         */
        public int Amount { get; private set; }

        /**
         *
         * FabricatorType Değeri
         *
         
         *
         */
        public TechType FabricatorType { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
