namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class ThermalLilyRangeCheckingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ThermalLilyRangeCheckingEventArgs(Vector3 position, float range, bool isPlayerInRange = false, bool isAllowed = true)
        {
            this.LilyPosition    = position;
            this.PlayerRange     = range;
            this.IsPlayerInRange = isPlayerInRange;
            this.IsAllowed       = isAllowed;
        }

        /**
         *
         * Position Değeri
         *
         
         *
         */
        public Vector3 LilyPosition { get; private set; }

        /**
         *
         * PlayerRange Değeri
         *
         
         *
         */
        public float PlayerRange { get; set; }

        /**
         *
         * IsPlayerInRange Değeri
         *
         
         *
         */
        public bool IsPlayerInRange { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}