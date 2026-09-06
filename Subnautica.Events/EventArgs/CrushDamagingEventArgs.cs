namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrushDamagingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrushDamagingEventArgs(string uniqueId, TechType techType, float maxHealth, float damage, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.TechType  = techType;
            this.Damage    = damage;
            this.MaxHealth = maxHealth;
            this.IsAllowed = isAllowed;
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
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * MaxHealth değeri
         *
         
         *
         */
        public float MaxHealth { get; set; }

        /**
         *
         * Damage değeri
         *
         
         *
         */
        public float Damage { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}