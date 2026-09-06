namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerPingVisibilityChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerPingVisibilityChangedEventArgs(string uniqueId, bool isVisible)
        {
            this.UniqueId  = uniqueId;
            this.IsVisible = isVisible;
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
         * IsVisible Değeri
         *
         
         *
         */
        public bool IsVisible { get; private set; }
    }
}