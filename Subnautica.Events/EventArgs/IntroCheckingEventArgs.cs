namespace Subnautica.Events.EventArgs
{
    using System;
    using System.Collections;

    public class IntroCheckingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public IntroCheckingEventArgs(bool isAllowed = true)
        {
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * WaitingMethod değeri
         *
         
         *
         */
        public IEnumerator WaitingMethod { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}