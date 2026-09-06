namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class StorySignalSpawningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StorySignalSpawningEventArgs(global::Story.UnlockSignalData.SignalType signalType, Vector3 targetPosition, string targetDescription, bool isAllowed = true)
        {
            this.SignalType         = signalType;
            this.TargetPosition     = targetPosition;
            this.TargetDescription  = targetDescription;
            this.IsAllowed          = isAllowed;
        }

        /**
         *
         * SignalType değeri
         *
         
         *
         */
        public global::Story.UnlockSignalData.SignalType SignalType { get; set; }

        /**
         *
         * TargetPosition Değeri
         *
         
         *
         */
        public Vector3 TargetPosition { get; set; }

        /**
         *
         * TargetDescription değeri
         *
         
         *
         */
        public string TargetDescription { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
