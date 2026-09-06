namespace Subnautica.Events.EventArgs
{
    using System;

    public class StorageOpeningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StorageOpeningEventArgs(string constructionId, TechType techType, bool isAllowed = true)
        {
            this.ConstructionId = constructionId;
            this.TechType       = techType;
            this.IsAllowed      = isAllowed;
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
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
