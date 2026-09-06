namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerPingColorChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerPingColorChangedEventArgs(string uniqueId, int colorIndex)
        {
            this.UniqueId   = uniqueId;
            this.ColorIndex = colorIndex;
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
         * ColorIndex Değeri
         *
         
         *
         */
        public int ColorIndex { get; private set; }
    }
}