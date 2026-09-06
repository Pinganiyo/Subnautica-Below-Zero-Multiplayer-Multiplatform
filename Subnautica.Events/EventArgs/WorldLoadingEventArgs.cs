namespace Subnautica.Events.EventArgs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class WorldLoadingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public WorldLoadingEventArgs(IEnumerator method = null)
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