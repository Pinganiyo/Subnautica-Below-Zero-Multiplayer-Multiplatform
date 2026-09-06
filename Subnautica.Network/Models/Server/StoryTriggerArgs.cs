namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class StoryTriggerArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StoryTrigger;

        /**
         *
         * GoalKey Değerini Barındırır.
         *
         
         *
         */
        [Key(5)]
        public string GoalKey { get; set; }

        /**
         *
         * StoryGoalKey Değeri
         *
         
         *
         */
        [Key(6)]
        public global::Story.GoalType GoalType { get; set; }

        /**
         *
         * CinematicType Değeri
         *
         
         *
         */
        [Key(7)]
        public StoryCinematicType CinematicType { get; set; }

        /**
         *
         * IsStoryGoalMuted Değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsStoryGoalMuted { get; set; }

        /**
         *
         * IsTrigger Değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsTrigger { get; set; }

        /**
         *
         * IsPlayMuted Değeri
         *
         
         *
         */
        [Key(10)]
        public bool IsPlayMuted { get; set; }

        /**
         *
         * IsTrigger Değeri
         *
         
         *
         */
        [Key(11)]
        public bool IsClearSound { get; set; }

        /**
         *
         * TriggerTime Değerini Barındırır.
         *
         
         *
         */
        [Key(12)]
        public float TriggerTime { get; set; }

        /**
         *
         * PlayerCount Değerini Barındırır.
         *
         
         *
         */
        [Key(13)]
        public byte PlayerCount { get; set; }

        /**
         *
         * MaxPlayerCount Değerini Barındırır.
         *
         
         *
         */
        [Key(14)]
        public byte MaxPlayerCount { get; set; }
    }
}