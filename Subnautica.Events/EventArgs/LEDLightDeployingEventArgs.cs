namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class LEDLightDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LEDLightDeployingEventArgs(string uniqueId, Vector3 position, Quaternion rotation, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
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
        public string UniqueId { get; set; }

        /**
         *
         * Position değeri
         *
         
         *
         */
        public Vector3 Position { get; set; }

        /**
         *
         * Rotation değeri
         *
         
         *
         */
        public Quaternion Rotation { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}