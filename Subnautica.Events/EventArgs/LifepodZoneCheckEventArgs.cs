namespace Subnautica.Events.EventArgs
{
    using System;

    public class LifepodZoneCheckEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LifepodZoneCheckEventArgs(string key, bool isAllowed = true)
        {
            this.Key       = key;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * Key değeri
         *
         
         *
         */
        public string Key { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}