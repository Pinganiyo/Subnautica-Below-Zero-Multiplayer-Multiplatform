namespace Subnautica.Events.EventArgs
{
    using System;

    public class LifepodZoneSelectingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LifepodZoneSelectingEventArgs(string key, bool isAllowed = true)
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
         * ZoneId değeri
         *
         
         *
         */
        public sbyte ZoneId { get; set; } = -1;

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}