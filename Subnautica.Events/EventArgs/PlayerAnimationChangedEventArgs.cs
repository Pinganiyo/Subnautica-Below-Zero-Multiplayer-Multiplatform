namespace Subnautica.Events.EventArgs
{
    using System;
    using System.Collections.Generic;

    using Subnautica.API.Enums;

    public class PlayerAnimationChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerAnimationChangedEventArgs(Dictionary<PlayerAnimationType, bool> animations)
        {
            this.Animations = animations;
        }

        /**
         *
         * Animations değeri
         *
         
         *
         */
        public Dictionary<PlayerAnimationType, bool> Animations { get; private set; } = new Dictionary<PlayerAnimationType, bool>();
    }
}