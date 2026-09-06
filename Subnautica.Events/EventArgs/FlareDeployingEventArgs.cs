namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class FlareDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public FlareDeployingEventArgs(string uniqueId, Pickupable pickupable, Vector3 deployPosition, float energy, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.Pickupable     = pickupable;
            this.DeployPosition = deployPosition;
            this.Forward        = global::MainCamera.camera.transform.forward;
            this.Energy         = energy;
            this.IsAllowed      = isAllowed;
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
         * Pickupable Değerini barındırır.
         *
         
         *
         */
        public Pickupable Pickupable { get; private set; }

        /**
         *
         * DeployPosition Değerini barındırır.
         *
         
         *
         */
        public Vector3 DeployPosition { get; private set; }

        /**
         *
         * Forward Değerini barındırır.
         *
         
         *
         */
        public Vector3 Forward { get; private set; }

        /**
         *
         * Energy Değerini barındırır.
         *
         
         *
         */
        public float Energy { get; private set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}