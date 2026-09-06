namespace Subnautica.Events.EventArgs
{
    using System;

    public class WeldingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public WeldingEventArgs(string uniqueId, TechType techType, float health, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.TechType  = techType;
            this.Health    = health;
            this.IsAllowed = isAllowed;
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
         * TechType Değerini barındırır.
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * Health Değerini barındırır.
         *
         
         *
         */
        public float Health { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
