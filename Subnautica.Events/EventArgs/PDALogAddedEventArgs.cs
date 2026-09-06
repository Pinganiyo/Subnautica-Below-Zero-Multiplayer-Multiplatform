namespace Subnautica.Events.EventArgs
{
    using System;

    public class PDALogAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PDALogAddedEventArgs(string key, float timestamp)
        {
            this.Key = key;
            this.Timestamp = timestamp;
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
         * Timestamp Değeri
         *
         
         *
         */
        public float Timestamp { get; private set; }
    }
}
