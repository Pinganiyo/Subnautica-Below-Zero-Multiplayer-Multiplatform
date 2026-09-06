namespace Subnautica.Events.EventArgs
{
    using System;
    using System.Collections.Generic;

    using Subnautica.API.Features;
    using Subnautica.Network.Structures;

    public class ExosuitDrillingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ExosuitDrillingEventArgs(string uniqueId, string slotId, float maxHealth, TechType dropTechType, List<ZeroVector3> dropPositions, bool isMultipleDrill, bool isAllowed = true)
        {
            this.UniqueId            = uniqueId;
            this.SlotId              = slotId;
            this.MaxHealth           = maxHealth;
            this.DropTechType        = dropTechType;
            this.DropPositions       = dropPositions;
            this.IsMultipleDrill     = isMultipleDrill;
            this.IsAllowed           = isAllowed;
            this.IsStaticWorldEntity = Network.StaticEntity.IsStaticEntity(slotId);
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
         * SlotId değeri
         *
         
         *
         */
        public string SlotId { get; set; }

        /**
         *
         * MaxHealth değeri
         *
         
         *
         */
        public float MaxHealth { get; set; }

        /**
         *
         * DropTechType değeri
         *
         
         *
         */
        public TechType DropTechType { get; set; }

        /**
         *
         * DropPositions değeri
         *
         
         *
         */
        public List<ZeroVector3> DropPositions { get; set; }

        /**
         *
         * IsMultipleDrill değeri
         *
         
         *
         */
        public bool IsMultipleDrill { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }

        /**
         *
         * Static nesne mi?
         *
         
         *
         */
        public bool IsStaticWorldEntity { get; set; }
    }
}
