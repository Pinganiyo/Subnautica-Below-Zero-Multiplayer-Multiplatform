namespace Subnautica.Events.EventArgs
{
    using System;

    public class WeatherProfileChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public WeatherProfileChangedEventArgs(string profileId, bool isProfile, bool isAllowed = true)
        {
            this.ProfileId = profileId;
            this.IsProfile = isProfile;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * ProfileId Değerini barındırır.
         *
         
         *
         */
        public string ProfileId { get; set; }

        /**
         *
         * IsProfile Değerini barındırır.
         *
         
         *
         */
        public bool IsProfile { get; set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
