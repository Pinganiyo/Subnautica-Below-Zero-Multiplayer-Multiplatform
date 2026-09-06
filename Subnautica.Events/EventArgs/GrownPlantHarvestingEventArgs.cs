namespace Subnautica.Events.EventArgs
{
    using System;

    public class GrownPlantHarvestingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public GrownPlantHarvestingEventArgs(string uniqueId, GrownPlant grownPlant, bool isAllowed = true)
        {
            this.UniqueId   = uniqueId;
            this.GrownPlant = grownPlant;
            this.IsAllowed  = isAllowed;
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
         * GrownPlant Değeri
         *
         
         *
         */
        public GrownPlant GrownPlant { get; private set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
