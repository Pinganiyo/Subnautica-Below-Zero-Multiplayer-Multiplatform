namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;

    public class StoryHandClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public StoryHandClickingEventArgs(string uniqueId, string goalKey, StoryCinematicType cinematicType, bool isAllowed = true)
        {
            this.UniqueId      = uniqueId;
            this.GoalKey       = goalKey;
            this.CinematicType = cinematicType;
            this.IsAllowed     = isAllowed;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * GoalKey değeri
         *
         
         *
         */
        public string GoalKey { get; set; }
        /**
         *
         * CinematicType değeri
         *
         
         *
         */
        public StoryCinematicType CinematicType { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
