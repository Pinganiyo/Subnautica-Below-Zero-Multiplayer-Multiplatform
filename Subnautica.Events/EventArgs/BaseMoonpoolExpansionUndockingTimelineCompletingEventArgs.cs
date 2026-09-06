namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BaseMoonpoolExpansionUndockingTimelineCompletingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseMoonpoolExpansionUndockingTimelineCompletingEventArgs(GameObject gameObject, bool isAllowed = true)
        {
            this.GameObject = gameObject;
            this.IsAllowed  = isAllowed;
        }

        /**
         *
         * GameObject değeri
         *
         
         *
         */
        public GameObject GameObject { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
