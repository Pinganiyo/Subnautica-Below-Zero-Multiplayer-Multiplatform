namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class BulkheadDoor : MetadataComponent
    {
        /**
         *
         * IsOpened Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsOpened { get; set; } = false;

        /**
         *
         * Side Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool Side { get; set; } = false;

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public BulkheadDoor()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public BulkheadDoor(bool isOpened, bool side)
        {
            this.IsOpened = isOpened;
            this.Side     = side;
        }
    }
}
