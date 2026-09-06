namespace Subnautica.Events.EventArgs
{
    using System;

    public class CreatureAttackLastTargetStoppedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureAttackLastTargetStoppedEventArgs(global::Creature creature, string uniqueId, bool isAttackAnimationActive)
        {
            this.UniqueId = uniqueId;
            this.Creature = creature;
            this.IsAttackAnimationActive = isAttackAnimationActive;
        }

        /**
         *
         * Yaratık benzersiz ID değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Creature değeri
         *
         
         *
         */
        public global::Creature Creature { get; set; }

        /**
         *
         * IsAttackAnimationActive değeri
         *
         
         *
         */
        public bool IsAttackAnimationActive { get; set; }
    }
}
