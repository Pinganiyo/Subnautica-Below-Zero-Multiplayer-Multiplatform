namespace Subnautica.Events.EventArgs
{
    using System;

    public class TeleporterInitializedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TeleporterInitializedEventArgs(string uniqueId, string teleporterId, bool isExit)
        {
            this.UniqueId     = uniqueId;
            this.TeleporterId = teleporterId;
            this.IsExit       = isExit;
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
         * TeleporterId Değerini barındırır.
         *
         
         *
         */
        public string TeleporterId { get; set; }

        /**
         *
         * IsExit Değerini barındırır.
         *
         
         *
         */
        public bool IsExit { get; set; }
    }
}
