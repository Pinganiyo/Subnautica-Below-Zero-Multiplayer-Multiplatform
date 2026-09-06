namespace Subnautica.Events.EventArgs
{
    using System;

    public class TechAnalyzeAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TechAnalyzeAddedEventArgs(TechType techType, bool verbose)
        {
            this.TechType = techType;
            this.Verbose  = verbose;
        }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Verbose değeri
         *
         
         *
         */
        public bool Verbose { get; private set; }
    }
}
