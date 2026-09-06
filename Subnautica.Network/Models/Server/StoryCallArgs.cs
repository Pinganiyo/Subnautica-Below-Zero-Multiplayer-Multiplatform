namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class StoryCallArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StoryCall;

        /**
         *
         * GoalKey Değeri
         *
         
         *
         */
        [Key(5)]
        public string GoalKey { get; set; }

        /**
         *
         * TargetGoalKey Değeri
         *
         
         *
         */
        [Key(6)]
        public string TargetGoalKey { get; set; }

        /**
         *
         * IsAnswered Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsAnswered { get; set; }
    }
}