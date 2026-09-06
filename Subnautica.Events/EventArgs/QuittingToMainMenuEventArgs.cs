namespace Subnautica.Events.EventArgs
{
    using System;

    public class QuittingToMainMenuEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public QuittingToMainMenuEventArgs(bool isQuitToDesktop, bool isAllowed = true)
        {
            this.IsQuitToDesktop = isQuitToDesktop;
            this.IsAllowed       = isAllowed;
        }

        /**
         *
         * Masaüstüne çıkış yapılsın mı?
         *
         
         *
         */
        public bool IsQuitToDesktop { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
