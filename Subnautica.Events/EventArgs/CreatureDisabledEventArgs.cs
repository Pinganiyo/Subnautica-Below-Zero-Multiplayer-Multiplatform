namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Extensions;

    public class CreatureDisabledEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureDisabledEventArgs(global::Creature creature)
        {
            this.Instance = creature;
            this.UniqueId = creature.gameObject.GetIdentityId();
            this.TechType = creature.gameObject.GetTechType();
        }

        /**
         *
         * Instance değeri
         *
         
         *
         */
        public global::Creature Instance { get; set; }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; set; }
    }
}