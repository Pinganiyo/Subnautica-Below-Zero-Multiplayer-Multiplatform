namespace Subnautica.Events.EventArgs
{
    using System;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features;

    using UnityEngine;

    public class TakeDamagingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TakeDamagingEventArgs(global::LiveMixin liveMixin, TechType techType, float damage, float oldHealth, float maxHealth, float newHealth, DamageType damageType, bool isDestroyable, GameObject dealer, bool isAllowed = true)
        {
            this.LiveMixin     = liveMixin;
            this.UniqueId      = Network.Identifier.GetIdentityId(liveMixin.gameObject, false);
            this.Dealer        = dealer;
            this.DealerId      = dealer != null ? Network.Identifier.GetIdentityId(dealer.gameObject, false) : null;
            this.TechType      = techType;
            this.Damage        = damage;
            this.OldHealth     = oldHealth;
            this.MaxHealth     = maxHealth;
            this.NewHealth     = newHealth;
            this.DamageType    = damageType;
            this.IsDead        = newHealth <= 0f;
            this.IsDestroyable = isDestroyable;
            this.IsAllowed     = isAllowed;

            if (this.UniqueId.IsNotNull())
            {
                this.IsStaticWorldEntity = Network.StaticEntity.IsStaticEntity(this.UniqueId);
            }
        }

        /**
         *
         * LiveMixin değeri
         *
         
         *
         */
        public global::LiveMixin LiveMixin { get; set; }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Dealer değeri
         *
         
         *
         */
        public GameObject Dealer { get; set; }

        /**
         *
         * DealerId değeri
         *
         
         *
         */
        public string DealerId { get; set; }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * Damage değeri
         *
         
         *
         */
        public float Damage { get; set; }

        /**
         *
         * OldHealth değeri
         *
         
         *
         */
        public float OldHealth { get; set; }

        /**
         *
         * MaxHealth değeri
         *
         
         *
         */
        public float MaxHealth { get; set; }

        /**
         *
         * NewHealth değeri
         *
         
         *
         */
        public float NewHealth { get; set; }

        /**
         *
         * DamageType değeri
         *
         
         *
         */
        public DamageType DamageType { get; set; }

        /**
         *
         * IsDestroyable değeri
         *
         
         *
         */
        public bool IsDestroyable { get; private set; }

        /**
         *
         * IsStaticWorldEntity değeri
         *
         
         *
         */
        public bool IsStaticWorldEntity { get; private set; }

        /**
         *
         * IsDead değeri
         *
         
         *
         */
        public bool IsDead { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}