namespace Subnautica.Events.EventArgs
{
    using System;

    public class MapRoomCameraChangingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public MapRoomCameraChangingEventArgs(string uniqueId, bool isNext, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.IsNext    = isNext;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * IsNext Değerini barındırır.
         *
         
         *
         */
        public bool IsNext { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
