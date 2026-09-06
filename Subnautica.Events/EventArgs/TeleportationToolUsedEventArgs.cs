namespace Subnautica.Events.EventArgs
{
    using System;

    public class TeleportationToolUsedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TeleportationToolUsedEventArgs(string teleporterId)
        {
            this.TeleporterId = teleporterId;
        }

        /**
         *
         * TeleporterId Değerini barındırır.
         *
         
         *
         */
        public string TeleporterId { get; set; }
    }
}