namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class GlowWhaleRideStopedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public GlowWhaleRideStopedEventArgs(string uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }
    }
}
