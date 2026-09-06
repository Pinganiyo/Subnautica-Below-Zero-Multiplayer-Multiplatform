namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class StoryBridgeArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StoryBridge;

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
         * StoryKey Değeri
         *
         
         *
         */
        [Key(6)]
        public string StoryKey { get; set; }

        /**
         *
         * IsClickedFluid Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsClickedFluid { get; set; }

        /**
         *
         * IsClickedExtend Değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsClickedExtend { get; set; }

        /**
         *
         * IsClickedRetract Değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsClickedRetract { get; set; }

        /**
         *
         * IsFirstExtension Değeri
         *
         
         *
         */
        [Key(10)]
        public bool IsFirstExtension { get; set; }

        /**
         *
         * Time Değeri
         *
         
         *
         */
        [Key(11)]
        public float Time { get; set; }
    }
}