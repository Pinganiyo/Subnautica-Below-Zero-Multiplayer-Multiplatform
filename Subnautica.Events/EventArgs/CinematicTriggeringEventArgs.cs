namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;

    public class CinematicTriggeringEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CinematicTriggeringEventArgs(string uniqueId, StoryCinematicType cinematicType, bool isClicked = false, bool isAllowed = true)
        {
            this.UniqueId           = uniqueId;
            this.StoryCinematicType = cinematicType;
            this.IsClicked          = isClicked;
            this.IsAllowed          = isAllowed;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * StoryCinematicType Değeri
         *
         
         *
         */
        public StoryCinematicType StoryCinematicType { get; private set; }

        /**
         *
         * IsClicked Değeri
         *
         
         *
         */
        public bool IsClicked { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
