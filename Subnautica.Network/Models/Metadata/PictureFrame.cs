namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class PictureFrame : MetadataComponent
    {
        /**
         *
         * ImageName barındırır.
         *
         
         *
         */
        [Key(0)]
        public string ImageName { get; set; }

        /**
         *
         * ImageData değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public byte[] ImageData { get; set; }

        /**
         *
         * ImageData değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsOpening { get; set; }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public PictureFrame()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public PictureFrame(string imageName, byte[] imageData, bool isOpening)
        {
            this.ImageName = imageName;
            this.ImageData = imageData;
            this.IsOpening = isOpening;
        }
    }
}
