namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class ConstructorDeployingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructorDeployingEventArgs(string uniqueId, Pickupable pickupable, Vector3 forward, Vector3 deployPosition, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.Pickupable     = pickupable;
            this.Forward        = forward;
            this.DeployPosition = deployPosition;
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
         * Forward Değerini barındırır.
         *
         
         *
         */
        public Vector3 Forward { get; set; }

        /**
         *
         * DeployPosition Değerini barındırır.
         *
         
         *
         */
        public Vector3 DeployPosition { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}