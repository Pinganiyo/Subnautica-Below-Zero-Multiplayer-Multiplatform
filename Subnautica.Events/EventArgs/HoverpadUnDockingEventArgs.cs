namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class HoverpadUnDockingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public HoverpadUnDockingEventArgs(string uniqueId, string itemId, Vector3 position, Quaternion rotation, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.ItemId    = itemId;
            this.Position  = position;
            this.Rotation  = rotation;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * ItemId Değerini barındırır.
         *
         
         *
         */
        public string ItemId { get; private set; }

        /**
         *
         * Position Değerini barındırır.
         *
         
         *
         */
        public Vector3 Position { get; private set; }

        /**
         *
         * Rotation Değerini barındırır.
         *
         
         *
         */
        public Quaternion Rotation { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
