namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class PlanterGrownedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlanterGrownedEventArgs(FruitPlant fruitPlant)
        {
            this.FruitPlant = fruitPlant;
        }

        /**
         *
         * FruitPlant Değeri
         *
         
         *
         */
        public FruitPlant FruitPlant { get; private set; }
    }
}
