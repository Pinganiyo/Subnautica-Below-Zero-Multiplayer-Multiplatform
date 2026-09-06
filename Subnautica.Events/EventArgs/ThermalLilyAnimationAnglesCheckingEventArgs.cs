namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class ThermalLilyAnimationAnglesCheckingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ThermalLilyAnimationAnglesCheckingEventArgs(Vector3 position, float range, Vector3 playerPosition = default(Vector3), bool isAllowed = true)
        {
            this.LilyPosition   = position;
            this.PlayerRange    = range;
            this.PlayerPosition = playerPosition;
            this.IsAllowed      = isAllowed;
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
         * PlayerPosition Değeri
         *
         
         *
         */
        public Vector3 PlayerPosition { get; set; }

        /**
         *
         * PlayerRange Değeri
         *
         
         *
         */
        public float PlayerRange { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}