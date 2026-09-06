namespace Subnautica.Events.EventArgs
{
    using System;

    public class LilyPaddlerHypnotizeStartingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LilyPaddlerHypnotizeStartingEventArgs(string creatureId, byte targetId, bool isAllowed = true)
        {
            this.CreatureId = creatureId;
            this.TargetId   = targetId;
            this.IsAllowed  = isAllowed;
        }

        /**
         *
         * CreatureId Değerini barındırır.
         *
         
         *
         */
        public string CreatureId { get; set; }

        /**
         *
         * TargetId Değerini barındırır.
         *
         
         *
         */
        public byte TargetId { get; set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}