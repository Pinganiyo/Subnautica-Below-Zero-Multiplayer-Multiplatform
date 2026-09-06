namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class PlayerClimbingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerClimbingEventArgs(string uniqueId, float duration, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.Duration  = duration;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Duration Değerini barındırır.
         *
         
         *
         */
        public float Duration { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}