namespace Subnautica.Events.EventArgs
{
    using System;

    public class JukeboxDiskPickedUpEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public JukeboxDiskPickedUpEventArgs(string uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }
    }
}