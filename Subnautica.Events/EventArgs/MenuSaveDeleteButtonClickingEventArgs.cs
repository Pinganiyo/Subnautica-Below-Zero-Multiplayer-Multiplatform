namespace Subnautica.Events.EventArgs
{
    using System;

    public class MenuSaveDeleteButtonClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public MenuSaveDeleteButtonClickingEventArgs(string sessiondId, bool isRunAnimation = false, bool isAllowed = true)
        {
            SessionId = sessiondId;
            IsRunAnimation = isRunAnimation;
            IsAllowed = isAllowed;
        }

        /**
         *
         * SessionId değeri
         *
         
         *
         */
        public string SessionId { get; set; }

        /**
         *
         * Animasyonun çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsRunAnimation { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
