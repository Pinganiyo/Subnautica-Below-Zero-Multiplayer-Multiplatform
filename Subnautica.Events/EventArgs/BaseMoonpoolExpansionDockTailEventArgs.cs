namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BaseMoonpoolExpansionDockTailEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseMoonpoolExpansionDockTailEventArgs(GameObject gameObject, global::SeaTruckSegment newTail, bool isAllowed = true)
        {
            this.GameObject = gameObject;
            this.NewTail    = newTail;
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
         * NewTail değeri
         *
         
         *
         */
        public global::SeaTruckSegment NewTail { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
