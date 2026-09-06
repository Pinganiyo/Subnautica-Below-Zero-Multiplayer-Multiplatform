namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BaseMoonpoolExpansionUndockTailEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseMoonpoolExpansionUndockTailEventArgs(GameObject gameObject, bool withEjection, bool isAllowed = true)
        {
            this.GameObject   = gameObject;
            this.WithEjection = withEjection;
            this.IsAllowed    = isAllowed;
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
         * WithEjection değeri
         *
         
         *
         */
        public bool WithEjection { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
