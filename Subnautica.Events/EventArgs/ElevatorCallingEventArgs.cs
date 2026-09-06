namespace Subnautica.Events.EventArgs
{
    using System;

    public class ElevatorCallingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ElevatorCallingEventArgs(string uniqueId, bool isUp, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.IsUp      = isUp;
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
         * IsUp Değerini barındırır.
         *
         
         *
         */
        public bool IsUp { get; set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
