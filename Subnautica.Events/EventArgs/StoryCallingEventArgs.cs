namespace Subnautica.Events.EventArgs
{
    using System;

    public class StoryCallingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StoryCallingEventArgs(string callGoalKey, string targetGoalKey, bool isAnswered, bool isAllowed = true)
        {
            this.CallGoalKey   = callGoalKey;
            this.TargetGoalKey = targetGoalKey;
            this.IsAnswered    = isAnswered;
            this.IsAllowed     = isAllowed;
        }

        /**
         *
         * CallGoalKey Değeri
         *
         
         *
         */
        public string CallGoalKey { get; private set; }

        /**
         *
         * TargetGoalKey Değeri
         *
         
         *
         */
        public string TargetGoalKey { get; private set; }

        /**
         *
         * IsAnswered Değeri
         *
         
         *
         */
        public bool IsAnswered { get; private set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}