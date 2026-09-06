namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class OxygenPipePlacingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public OxygenPipePlacingEventArgs(string uniqueId, string parentId, string pipeId, Pickupable pickupable, Vector3 deployPosition, Quaternion deployRotation, bool isAllowed = true)
        {
            this.UniqueId       = uniqueId;
            this.ParentId       = parentId;   
            this.PipeId         = pipeId;
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
         * ParentId Değerini barındırır.
         *
         
         *
         */
        public string ParentId { get; set; }

        /**
         *
         * PipeId Değerini barındırır.
         *
         
         *
         */
        public string PipeId { get; set; }

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