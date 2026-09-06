namespace Subnautica.Events.EventArgs
{
    using System;

    public class InGameMenuClosingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public InGameMenuClosingEventArgs(bool isAllowed = true)
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
