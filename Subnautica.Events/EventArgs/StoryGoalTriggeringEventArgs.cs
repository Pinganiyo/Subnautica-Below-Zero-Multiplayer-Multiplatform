namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;

    public class StoryGoalTriggeringEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StoryGoalTriggeringEventArgs(string storyKey, global::Story.GoalType goalType, bool isPlayMuted, bool isStoryGoalMuted = false, StoryCinematicType cinematicType = StoryCinematicType.None, bool isAllowed = true)
        {
            this.StoryKey         = storyKey;
            this.GoalType         = goalType;
            this.IsPlayMuted      = isPlayMuted;
            this.IsStoryGoalMuted = isStoryGoalMuted;
            this.CinematicType    = cinematicType;
            this.IsAllowed        = isAllowed;
        }

        /**
         *
         * StoryKey değeri
         *
         
         *
         */
        public string StoryKey { get; set; }

        /**
         *
         * GoalType değeri
         *
         
         *
         */
        public global::Story.GoalType GoalType { get; set; }

        /**
         *
         * IsPlayMuted değeri
         *
         
         *
         */
        public bool IsPlayMuted { get; set; }

        /**
         *
         * IsStoryGoalMuted değeri
         *
         
         *
         */
        public bool IsStoryGoalMuted { get; set; }

        /**
         *
         * CinematicType değeri
         *
         
         *
         */
        public StoryCinematicType CinematicType { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}