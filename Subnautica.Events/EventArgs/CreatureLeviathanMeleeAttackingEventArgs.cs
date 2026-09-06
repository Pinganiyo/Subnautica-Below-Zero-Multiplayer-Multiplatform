namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Extensions;

    using UnityEngine;

    public class CreatureLeviathanMeleeAttackingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureLeviathanMeleeAttackingEventArgs(global::LeviathanMeleeAttack instance, GameObject target, bool isAllowed = true)
        {
            this.Instance   = instance;
            this.UniqueId   = instance.creature.gameObject.GetIdentityId();
            this.BiteDamage = instance.biteDamage;
            this.Target     = target;
            this.TargetId   = target.GetIdentityId();
            this.TargetType = target.GetTechType();
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
         * Instance değeri
         *
         
         *
         */
        public global::LeviathanMeleeAttack Instance { get; set; }

        /**
         *
         * Target değeri
         *
         
         *
         */
        public GameObject Target { get; set; }

        /**
         *
         * TargetId değeri
         *
         
         *
         */
        public string TargetId { get; set; }

        /**
         *
         * TargetType değeri
         *
         
         *
         */
        public TechType TargetType { get; set; }

        /**
         *
         * BiteDamage değeri
         *
         
         *
         */
        public float BiteDamage { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
