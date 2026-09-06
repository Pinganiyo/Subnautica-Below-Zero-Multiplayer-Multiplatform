namespace Subnautica.Server.Events.EventArgs
{
    using System;

    using Subnautica.Server.Core;

    public class PlayerFullConnectedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerFullConnectedEventArgs(AuthorizationProfile player)
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