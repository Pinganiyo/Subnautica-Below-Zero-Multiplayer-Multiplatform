namespace Subnautica.Events.EventArgs
{
    using System;

    public class LightChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LightChangedEventArgs(string uniqueId, bool isActive, TechType techType)
        {
            this.UniqueId = uniqueId;
            this.IsActive = isActive;
            this.TechType = techType;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * IsActive değeri
         *
         
         *
         */
        public bool IsActive { get; set; }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; set; }
    }
}
