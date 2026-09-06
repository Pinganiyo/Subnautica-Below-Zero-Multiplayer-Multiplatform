namespace Subnautica.Events.EventArgs
{
    using System;

    public class SpyPenguinItemGrabingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SpyPenguinItemGrabingEventArgs(string uniqueId, string animationName)
        {
            this.UniqueId      = uniqueId;
            this.AnimationName = animationName;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * AnimationName Değerini barındırır.
         *
         
         *
         */
        public string AnimationName { get; set; }
    }
}