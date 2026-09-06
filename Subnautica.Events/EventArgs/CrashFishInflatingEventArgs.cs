namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrashFishInflatingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrashFishInflatingEventArgs(string uniqueId, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
