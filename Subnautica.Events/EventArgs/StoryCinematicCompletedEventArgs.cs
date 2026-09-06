namespace Subnautica.Events.EventArgs
{
    using System;

    public class StoryCinematicCompletedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StoryCinematicCompletedEventArgs(string cinematicName)
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
