namespace Subnautica.Events.EventArgs
{
    using System;

    public class BridgeTerminalClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BridgeTerminalClickingEventArgs(string uniqueId, bool isExtend, double time, bool isAllowed = true)
        {
            this.UniqueId = uniqueId;
            this.IsExtend = isExtend;
            this.Time     = (float) time;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * IsExtend Değeri
         *
         
         *
         */
        public bool IsExtend { get; set; }

        /**
         *
         * Time Değeri
         *
         
         *
         */
        public float Time { get; set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}