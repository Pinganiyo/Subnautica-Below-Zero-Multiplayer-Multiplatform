namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerDeadEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerDeadEventArgs(DamageType damageType)
        {
            this.DamageType = damageType;
        }

        /**
         *
         * DamageType değeri
         *
         
         *
         */
        public DamageType DamageType { get; set; }
    }
}