namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.API.Features;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class SeaTruckSleeperModuleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SeaTruckSleeperModule;

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * IsOpeningPictureFrame Değeri
         *
         
         *
         */
        [Key(6)]
        public bool IsOpeningPictureFrame { get; set; }

        /**
         *
         * IsSelectingPictureFrame Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsSelectingPictureFrame { get; set; }

        /**
         *
         * PictureFrameData Değeri
         *
         
         *
         */
        [Key(8)]
        public byte[] PictureFrameData { get; set; }

        /**
         *
         * PictureFrameName Değeri
         *
         
         *
         */
        [Key(9)]
        public string PictureFrameName { get; set; }

        /**
         *
         * JukeboxData Değerini barındırır.
         *
         
         *
         */
        [Key(10)]
        public CustomProperty JukeboxData { get; set; }

        /**
         *
         * SleepingSide Değerini barındırır.
         *
         
         *
         */
        [Key(11)]
        public Bed.BedSide SleepingSide { get; set; }

        /**
         *
         * IsSleeping Değerini barındırır.
         *
         
         *
         */
        [Key(12)]
        public bool IsSleeping { get; set; }
    }
}