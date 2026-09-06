namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class PipeSurfaceFloaterDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PipeSurfaceFloaterDeployingEventArgs(string uniqueId, Pickupable pickupable, Vector3 deployPosition, Quaternion deployRotation, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.Pickupable     = pickupable;
            this.DeployPosition = deployPosition;
            this.DeployRotation = deployRotation;
            this.IsAllowed      = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Pickupable Değerini barındırır.
         *
         
         *
         */
        public Pickupable Pickupable { get; set; }

        /**
         *
         * DeployPosition Değerini barındırır.
         *
         
         *
         */
        public Vector3 DeployPosition { get; set; }

        /**
         *
         * DeployRotation Değerini barındırır.
         *
         
         *
         */
        public Quaternion DeployRotation { get; set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}