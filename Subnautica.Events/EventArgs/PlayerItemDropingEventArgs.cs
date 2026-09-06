namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class PlayerItemDropingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerItemDropingEventArgs(string uniqueId, Pickupable item, Vector3 position, Quaternion rotation,  bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.Item      = item;
            this.Position  = position;
            this.Rotation  = rotation;
            this.IsAllowed = isAllowed;
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
         * Item değeri
         *
         
         *
         */
        public Pickupable Item { get; private set; }

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
