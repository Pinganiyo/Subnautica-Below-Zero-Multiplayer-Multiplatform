namespace Subnautica.Events.EventArgs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class WorldLoadedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public WorldLoadedEventArgs()
        {
            this.WaitingMethods = new List<IEnumerator>();
        }

        /**
         *
         * WaitingMethods Değeri
         *
         
         *
         */
        public List<IEnumerator> WaitingMethods { get; set; }
    }
}
