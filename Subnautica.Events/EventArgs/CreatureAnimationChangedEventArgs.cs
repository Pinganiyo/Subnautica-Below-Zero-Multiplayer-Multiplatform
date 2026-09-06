namespace Subnautica.Events.EventArgs
{
    using System;

    public class CreatureAnimationChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureAnimationChangedEventArgs(ushort creatureId, byte animationId, byte result)
        {
            this.CreatureId  = creatureId;
            this.AnimationId = animationId;
            this.Result      = result;
        }

        /**
         *
         * CreatureId değeri
         *
         
         *
         */
        public ushort CreatureId { get; private set; }

        /**
         *
         * AnimationId değeri
         *
         
         *
         */
        public byte AnimationId { get; private set; }

        /**
         *
         * Result değeri
         *
         
         *
         */
        public byte Result { get; private set; }
    }
}