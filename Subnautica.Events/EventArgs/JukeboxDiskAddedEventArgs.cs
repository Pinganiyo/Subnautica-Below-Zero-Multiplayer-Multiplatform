namespace Subnautica.Events.EventArgs
{
    using System;

    public class JukeboxDiskAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public JukeboxDiskAddedEventArgs(string trackFile, bool notify)
        {
            TrackFile = trackFile;
            Notify = notify;
        }

        /**
         *
         * TrackFile Değeri
         *
         
         *
         */
        public string TrackFile { get; private set; }

        /**
         *
         * Notify Değeri
         *
         
         *
         */
        public bool Notify { get; private set; }
    }
}
