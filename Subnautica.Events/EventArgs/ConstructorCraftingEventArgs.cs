namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class ConstructorCraftingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructorCraftingEventArgs(string uniqueId, TechType techType, Vector3 position, Quaternion rotation, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.TechType  = techType;
            this.Position  = position;
            this.Rotation  = rotation;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId değeri
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
         * Position değeri
         *
         
         *
         */
        public Vector3 Position { get; private set; }

        /**
         *
         * Rotation değeri
         *
         
         *
         */
        public Quaternion Rotation { get; private set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}