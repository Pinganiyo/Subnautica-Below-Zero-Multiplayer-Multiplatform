namespace Subnautica.Events.EventArgs
{
    using System;

    public class StoryCinematicStartedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StoryCinematicStartedEventArgs(string cinematicName)
        {
            this.CinematicName = cinematicName;
        }

        /**
         *
         * CinematicName değeri
         *
         
         *
         */
        public string CinematicName { get; set; }
    }
}
