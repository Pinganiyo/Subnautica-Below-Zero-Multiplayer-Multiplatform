namespace Subnautica.Events.EventArgs
{
    using System;

    public class BaseControlRoomCellPowerChangingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseControlRoomCellPowerChangingEventArgs(string uniqueId, Int3 cell, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.Cell      = cell;
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
         * Cell değeri
         *
         
         *
         */
        public Int3 Cell { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
