namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class VehicleUpdatedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public VehicleUpdatedEventArgs(string uniqueId, Vector3 position, Quaternion rotation, TechType techType, GameObject gameObject)
        {
            this.UniqueId = uniqueId;
            this.Position = position;
            this.Rotation = rotation;
            this.TechType = techType;
            this.Instance = gameObject;
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
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Instance Değeri
         *
         
         *
         */
        public GameObject Instance { get; private set; }
    }
}
