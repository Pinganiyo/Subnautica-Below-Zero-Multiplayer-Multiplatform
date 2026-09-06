namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class CreatureAttackLastTargetStartingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureAttackLastTargetStartingEventArgs(global::Creature creature, string uniqueId, GameObject target, float minAttackDuration, float maxAttackDuration, bool isAllowed = true)
        {
            this.UniqueId   = uniqueId;
            this.Creature   = creature;
            this.Target     = target;
            this.MinAttackDuration = minAttackDuration;
            this.MaxAttackDuration = maxAttackDuration;
            this.IsAllowed  = isAllowed;
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
         * Target değeri
         *
         
         *
         */
        public GameObject Target { get; set; }

        /**
         *
         * MinAttackDuration değeri
         *
         
         *
         */
        public float MinAttackDuration { get; set; }

        /**
         *
         * MaxAttackDuration değeri
         *
         
         *
         */
        public float MaxAttackDuration { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
