namespace Subnautica.Events.EventArgs
{
    using System;

    public class BridgeFluidClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BridgeFluidClickingEventArgs(string uniqueId, string storyKey, bool isAllowed = true)
        {
            this.UniqueId = uniqueId;
            this.StoryKey = storyKey;
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
         * StoryKey Değeri
         *
         
         *
         */
        public string StoryKey { get; private set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}