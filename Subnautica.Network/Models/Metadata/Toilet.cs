namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Toilet : MetadataComponent
    {
        /**
         *
         * IsOpened değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsOpened { get; set; }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public Toilet()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public Toilet(bool isOpened)
        {
            this.IsOpened = isOpened;
        }
    }
}
