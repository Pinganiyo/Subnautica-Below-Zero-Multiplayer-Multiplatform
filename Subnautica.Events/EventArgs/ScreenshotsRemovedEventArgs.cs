namespace Subnautica.Events.EventArgs
{
    using System;

    public class ScreenshotsRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ScreenshotsRemovedEventArgs(string imageName)
        {
            this.ImageName = imageName;
        }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string ImageName { get; private set; }
    }
}