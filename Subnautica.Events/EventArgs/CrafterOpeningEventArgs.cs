namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrafterOpeningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrafterOpeningEventArgs(string uniqueId, TechType fabricatorType, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.FabricatorType = fabricatorType;
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
         * FabricatorType Değeri
         *
         
         *
         */
        public TechType FabricatorType { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}