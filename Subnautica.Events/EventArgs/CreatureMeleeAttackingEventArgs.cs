namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Extensions;

    using UnityEngine;

    public class CreatureMeleeAttackingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureMeleeAttackingEventArgs(global::MeleeAttack instance, GameObject target, bool isAllowed = true)
        {
            this.Instance   = instance;
            this.UniqueId   = instance.creature.gameObject.GetIdentityId();
            this.BiteDamage = instance.GetBiteDamage(target);
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
        public global::MeleeAttack Instance { get; set; }

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
