namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class SleepTimeSkipArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SleepTimeSkip;

        /**
         *
         * TimeLastSleep Değeri
         *
         
         *
         */
        [Key(5)]
        public float TimeLastSleep { get; set; }

        /**
         *
         * SkipModeEndTime Değeri
         *
         
         *
         */
        [Key(6)]
        public float SkipModeEndTime { get; set; }

        /**
         *
         * TimeAmount Değeri
         *
         
         *
         */
        [Key(7)]
        public float TimeAmount { get; set; }

        /**
         *
         * SkipDuration Değeri
         *
         
         *
         */
        [Key(8)]
        public float SkipDuration { get; set; }
    }
}
