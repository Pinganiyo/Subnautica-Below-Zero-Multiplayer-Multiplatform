namespace Subnautica.Events.EventArgs
{
    using System;

    public class SettingsPdaGamePauseChangingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SettingsPdaGamePauseChangingEventArgs(bool isAllowed = true)
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