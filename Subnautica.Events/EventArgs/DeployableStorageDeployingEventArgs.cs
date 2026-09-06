namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class DeployableStorageDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public DeployableStorageDeployingEventArgs(string uniqueId, Pickupable pickupable, Vector3 deployPosition, Vector3 forward, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.Pickupable     = pickupable;
            this.DeployPosition = deployPosition;
            this.Forward        = forward;
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
         * Forward Değerini barındırır.
         *
         
         *
         */
        public Vector3 Forward { get; set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}