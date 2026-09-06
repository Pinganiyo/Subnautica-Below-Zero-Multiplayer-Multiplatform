namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared
{
    using MessagePack;

    using UnityEngine;

    [MessagePackObject]
    public class LiveMixin
    {
        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(0)]
        public float Health { get; set; }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(1)]
        public float MaxHealth { get; set; }

        /**
         *
         * Öldü mü?
         *
         
         *
         */
        [IgnoreMember]
        public bool IsDead
        {
            get
            {
                return this.Health == 0;
            }
        }

        /**
         *
         * Sağlık Full mü?
         *
         
         *
         */
        [IgnoreMember]
        public bool IsHealthFull
        {
            get
            {
                return this.Health == this.MaxHealth;
            }
        }

        /**
         *
         * Tek saldırıda max hasar yüzdesini barındırır
         *
         
         *
         */
        [IgnoreMember]
        public float MaxDamagePercent { get; set; } = 0.16f;

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public LiveMixin()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public LiveMixin(float health, float maxHealth)
        {
            this.Health    = health;
            this.MaxHealth = maxHealth;
        }

        /**
         *
         * Sağlığa ekleme yapar.
         *
         
         *
         */
        public bool AddHealth(float health)
        {
            if (this.IsHealthFull)
            {
                return false;
            }

            this.Health = Mathf.Min(this.MaxHealth, this.Health + health);
            return true;
        }

        /**
         *
         * Sağlığı max yapar.
         *
         
         *
         */
        public void ResetHealth()
        {
            this.Health = this.MaxHealth;
        }

        /**
         *
         * Yeni sağlığı ayarlar.
         *
         
         *
         */
        public void SetHealth(float health)
        {
            this.Health = health;
        }

        /**
         *
         * Hasarı hesaplar.
         *
         
         *
         */
        public float CalculateDamage(float damage, DamageType damageType)
        {
            if (damageType == DamageType.Starve)
            {
                return damage;
            }

            float maxDamage = this.MaxHealth * this.MaxDamagePercent;

            if (damage > maxDamage)
            {
                damage = maxDamage;
            }

            return damage;
        }

        /**
         *
         * Nesneye hasar verir.
         *
         
         *
         */
        public bool TakeDamage(float damage)
        {
            if (this.IsDead || damage <= 0.0f)
            {
                return false;
            }

            this.Health = Mathf.Max(0, this.Health - damage);
            return true;
        }

        /**
         *
         * Nesneyi öldürür.
         *
         
         *
         */
        public bool Kill()
        {
            if (this.IsDead)
            {
                return false;
            }

            this.Health = 0;
            return true;
        }
    }
}
