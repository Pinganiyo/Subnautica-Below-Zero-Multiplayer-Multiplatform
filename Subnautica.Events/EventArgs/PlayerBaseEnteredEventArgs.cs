namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerBaseEnteredEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerBaseEnteredEventArgs(string uniqueId)
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
