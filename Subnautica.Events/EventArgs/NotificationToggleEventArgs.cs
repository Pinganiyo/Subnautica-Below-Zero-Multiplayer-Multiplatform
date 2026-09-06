namespace Subnautica.Events.EventArgs
{
    using System;

    using static NotificationManager;

    public class NotificationToggleEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public NotificationToggleEventArgs(Group group, string key, bool isAdded)
        {
            this.Group   = group;
            this.Key     = key;
            this.IsAdded = isAdded;
        }

        /**
         *
         * Group değeri
         *
         
         *
         */
        public Group Group { get; set; }

        /**
         *
         * Key değeri
         *
         
         *
         */
        public string Key { get; set; }

        /**
         *
         * IsAdded değeri
         *
         
         *
         */
        public bool IsAdded { get; set; }
    }
}
