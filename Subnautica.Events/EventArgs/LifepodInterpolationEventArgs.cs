namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class LifepodInterpolationEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LifepodInterpolationEventArgs(GameObject dropObject, bool isAllowed = true)
        {
            this.DropObject  = dropObject;
            this.IsAllowed   = isAllowed;
        }

        /**
         *
         * DropObject değeri
         *
         
         *
         */
        public GameObject DropObject { get; set; }

        /**
         *
         * IsCompleted değeri
         *
         
         *
         */
        public bool IsCompleted { get; set; }

        /**
         *
         * Rotation değeri
         *
         
         *
         */
        public Quaternion Rotation { get; set; }

        /**
         *
         * TimeLeft değeri
         *
         
         *
         */
        public float StartedTime { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}