namespace Subnautica.Server.Events.EventArgs
{
    using System;

    using Subnautica.Server.Core;

    public class PlayerDisconnectedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerDisconnectedEventArgs(AuthorizationProfile player)
        {
            this.Player = player;
        }

        /**
         *
         * Player değeri
         *
         
         *
         */
        public AuthorizationProfile Player { get; set; }
    }
}