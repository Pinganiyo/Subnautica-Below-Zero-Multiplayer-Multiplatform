namespace Subnautica.Events.EventArgs
{
    using System;

    public class TeleporterTerminalActivatingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TeleporterTerminalActivatingEventArgs(string uniqueId, string teleporterId, bool isAllowed = true)
        {
            this.UniqueId     = uniqueId;
            this.TeleporterId = teleporterId;
            this.IsAllowed    = isAllowed;
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
         * TeleporterId değeri
         *
         
         *
         */
        public string TeleporterId { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
