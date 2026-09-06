namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BeaconDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BeaconDeployingEventArgs(string uniqueId, Pickupable pickupable, Vector3 deployPosition, Quaternion deployRotation, bool isDeployedOnLand, string label, bool isAllowed = true)
        {
            this.UniqueId         = uniqueId;
            this.Pickupable       = pickupable;
            this.DeployPosition   = deployPosition;
            this.DeployRotation   = deployRotation;
            this.IsDeployedOnLand = isDeployedOnLand;
            this.Text             = label;
            this.IsAllowed        = isAllowed;
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
         * IsDeployedOnLand Değerini barındırır.
         *
         
         *
         */
        public bool IsDeployedOnLand { get; set; }

        /**
         *
         * Text Değerini barındırır.
         *
         
         *
         */
        public string Text { get; set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}