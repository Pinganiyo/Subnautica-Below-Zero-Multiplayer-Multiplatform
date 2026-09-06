namespace Subnautica.Events.EventArgs
{
    using System;

    public class RadioTowerTOMUsingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public RadioTowerTOMUsingEventArgs(string uniqueId, bool isAllowed = true)
        {
            this.UniqueId = uniqueId;
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
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}