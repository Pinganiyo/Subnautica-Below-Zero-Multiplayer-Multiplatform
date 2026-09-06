namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class PlanterProgressCompletedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlanterProgressCompletedEventArgs(Plantable plantable, GameObject grownPlant)
        {
            this.Plantable  = plantable;
            this.GrownPlant = grownPlant;
        }

        /**
         *
         * Plantable Değeri
         *
         
         *
         */
        public Plantable Plantable { get; private set; }

        /**
         *
         * GrownPlant Değeri
         *
         
         *
         */
        public GameObject GrownPlant { get; private set; }
    }
}

