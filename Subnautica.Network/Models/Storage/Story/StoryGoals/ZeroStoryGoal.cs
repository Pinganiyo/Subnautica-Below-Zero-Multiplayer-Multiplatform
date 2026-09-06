namespace Subnautica.Network.Models.Storage.Story.StoryGoals
{
    using MessagePack;

    [MessagePackObject]
    public class ZeroStoryGoal
    {
        /**
         *
         * Hedef Anahtarı
         *
         
         *
         */
        [Key(0)]
        public string Key { get; set; }

        /**
         *
         * GoalType Değeri
         *
         
         *
         */
        [Key(1)]
        public global::Story.GoalType GoalType { get; set; }

        /**
         *
         * IsPlayMuted Değeri
         *
         
         *
         */
        [Key(2)]
        public bool IsPlayMuted { get; set; }

        /**
         *
         * Time Değeri
         *
         
         *
         */
        [Key(3)]
        public float FinishedTime { get; set; }
    }
}
