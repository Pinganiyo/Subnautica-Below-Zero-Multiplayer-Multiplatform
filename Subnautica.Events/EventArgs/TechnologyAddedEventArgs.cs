namespace Subnautica.Events.EventArgs
{
    using System;

    public class TechnologyAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TechnologyAddedEventArgs(TechType type, bool verbose)
        {
            this.TechType = type;
            this.Verbose  = verbose;
        }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Verbose Değeri
         *
         
         *
         */
        public bool Verbose { get; private set; }
    }
}
