namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerBaseExitedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerBaseExitedEventArgs(string uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        /**
         *
         * Yapı Kimliği değeri
         *
         
         *
         */
        public string UniqueId { get; }
    }
}
