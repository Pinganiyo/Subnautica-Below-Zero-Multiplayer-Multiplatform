namespace Subnautica.Network.Models.Storage.PictureFrame
{
    using MessagePack;

    using System;
    using System.Collections.Generic;

    [MessagePackObject]
    [Serializable]
    public class PictureFrame
    {
        /**
         *
         * Resimleri barındırır.
         *
         
         *
         */
        [Key(0)]
        public Dictionary<string, Metadata.PictureFrame> Images { get; set; } = new Dictionary<string, Metadata.PictureFrame>();
    }
}
