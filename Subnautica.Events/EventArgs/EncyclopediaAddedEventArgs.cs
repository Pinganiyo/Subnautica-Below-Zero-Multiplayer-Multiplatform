namespace Subnautica.Events.EventArgs
{
    using System;

    public class EncyclopediaAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EncyclopediaAddedEventArgs(string key, bool verbose)
        {
            this.Key = key;
            this.Verbose = verbose;
        }

        /**
         *
         * Key Değeri
         *
         
         *
         */
        public string Key { get; private set; }

        /**
         *
         * Verbose Değeri
         *
         
         *
         */
        public bool Verbose { get; private set; }
    }
}
