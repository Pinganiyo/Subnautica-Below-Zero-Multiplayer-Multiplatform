namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class HoverbikeDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public HoverbikeDeployingEventArgs(string uniqueId, Hoverbike hoverbike, Vector3 deployPosition, Vector3 forward, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.Hoverbike      = hoverbike;
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
         * Hoverbike Değerini barındırır.
         *
         
         *
         */
        public Hoverbike Hoverbike { get; set; }

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