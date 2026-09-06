namespace Subnautica.Events.EventArgs
{
    using System;

    public class InGameMenuOpeningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public InGameMenuOpeningEventArgs(bool isAllowed = true)
        {
            IsAllowed = isAllowed;
        }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
