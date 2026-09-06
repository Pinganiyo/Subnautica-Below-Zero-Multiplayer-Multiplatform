namespace Subnautica.Events.EventArgs
{
    using System;

    public class OxygenPlantClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public OxygenPlantClickingEventArgs(string uniqueId, float startedTime)
        {
            this.UniqueId    = uniqueId;
            this.StartedTime = startedTime;
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
         * StartedTime Değeri
         *
         
         *
         */
        public float StartedTime { get; private set; }
    }
}
