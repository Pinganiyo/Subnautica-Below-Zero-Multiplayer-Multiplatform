namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerFreezedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerFreezedEventArgs(float endTime)
        {
            this.EndTime = endTime;
        }

        /**
         *
         * EndTime Değerini barındırır.
         *
         
         *
         */
        public float EndTime { get; set; }
    }
}
