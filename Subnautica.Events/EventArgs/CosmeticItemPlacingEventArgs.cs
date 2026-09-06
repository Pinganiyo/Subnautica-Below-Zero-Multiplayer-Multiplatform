namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class CosmeticItemPlacingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CosmeticItemPlacingEventArgs(string uniqueId, string baseId, TechType techType, Vector3 position, Quaternion rotation, bool isAllowed = true)
        {
            this.UniqueId = uniqueId;
            this.BaseId   = baseId;
            this.TechType = techType;
            this.Position = position;
            this.Rotation = rotation;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * BaseId Değeri
         *
         
         *
         */
        public string BaseId { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Position Değeri
         *
         
         *
         */
        public Vector3 Position { get; private set; }

        /**
         *
         * Rotation Değeri
         *
         
         *
         */
        public Quaternion Rotation { get; private set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}