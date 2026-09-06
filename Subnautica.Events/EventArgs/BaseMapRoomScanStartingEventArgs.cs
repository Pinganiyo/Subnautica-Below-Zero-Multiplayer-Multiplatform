namespace Subnautica.Events.EventArgs
{
    using System;

    public class BaseMapRoomScanStartingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseMapRoomScanStartingEventArgs(string uniqueId, TechType scanType, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.ScanType  = scanType;
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
         * ScanType değeri
         *
         
         *
         */
        public TechType ScanType { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
