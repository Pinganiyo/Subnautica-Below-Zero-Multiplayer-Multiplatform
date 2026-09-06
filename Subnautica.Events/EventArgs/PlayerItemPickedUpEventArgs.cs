namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Features;

    public class PlayerItemPickedUpEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerItemPickedUpEventArgs(string uniqueId, TechType techType, Pickupable pickupable, bool isAllowed = true)
        {
            this.UniqueId   = uniqueId;
            this.TechType   = techType;
            this.Pickupable = pickupable;
            this.IsAllowed  = isAllowed;
            this.IsStaticWorldEntity = Network.StaticEntity.IsStaticEntity(uniqueId);
        }

        /**
         *
         * Yapı Kimliği değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Pickupable değeri
         *
         
         *
         */
        public Pickupable Pickupable { get; private set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }

        /**
         *
         * IsStaticWorldEntity değeri
         *
         
         *
         */
        public bool IsStaticWorldEntity { get; private set; }
    }
}
