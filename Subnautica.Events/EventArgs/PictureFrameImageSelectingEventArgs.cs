namespace Subnautica.Events.EventArgs
{
    using System;

    public class PictureFrameImageSelectingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PictureFrameImageSelectingEventArgs(string uniqueId, string imagename, byte[] imageData, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.ImageName = imagename;
            this.ImageData = imageData;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * ImageName değeri
         *
         
         *
         */
        public string ImageName { get; set; }

        /**
         *
         * ImageData Değeri
         *
         
         *
         */
        public byte[] ImageData { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
