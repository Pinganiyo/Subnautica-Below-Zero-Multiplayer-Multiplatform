namespace Subnautica.Events.EventArgs
{
    using System;
    using System.Collections.Generic;

    public class AquariumDataChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public AquariumDataChangedEventArgs(string uniqueId, List<TechType> fishes)
        {
            this.UniqueId = uniqueId;
            this.Fishes   = fishes;
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
         * Fishes Değeri
         *
         
         *
         */
        public List<TechType> Fishes { get; private set; }
    }
}