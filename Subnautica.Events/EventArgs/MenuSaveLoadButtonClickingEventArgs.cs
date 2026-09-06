namespace Subnautica.Events.EventArgs
{
    using System;

    public class MenuSaveLoadButtonClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public MenuSaveLoadButtonClickingEventArgs(string sessiondId, bool isAllowed = true)
        {
            SessionId = sessiondId;
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
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
