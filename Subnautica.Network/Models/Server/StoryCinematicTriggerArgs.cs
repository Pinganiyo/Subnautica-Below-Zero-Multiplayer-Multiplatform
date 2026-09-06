namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class StoryCinematicTriggerArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StoryCinematicTrigger;

        /**
         *
         * UniqueId Değerini Barındırır.
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * CinematicType Değeri
         *
         
         *
         */
        [Key(6)]
        public StoryCinematicType CinematicType { get; set; }

        /**
         *
         * StartTime Değeri
         *
         
         *
         */
        [Key(7)]
        public double StartTime { get; set; }

        /**
         *
         * IsTypeClick Değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsTypeClick { get; set; }
    }
}