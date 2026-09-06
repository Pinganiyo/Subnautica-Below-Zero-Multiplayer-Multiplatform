namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerEnteredInteriorEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerEnteredInteriorEventArgs(string uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }
    }
}
