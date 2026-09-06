namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Features;

    using UnityEngine;

    public class VehicleDockingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public VehicleDockingEventArgs(string uniqueId, GameObject vehicle, TechType MoonpoolType, Vector3 backModulePosition, Vector3 endPosition, Quaternion endRotation, bool isAllowed = true)
        {
            this.UniqueId     = uniqueId;
            this.VehicleId    = Network.Identifier.GetIdentityId(vehicle, false);
            this.Vehicle      = vehicle;
            this.MoonpoolType = MoonpoolType;
            this.EndPosition  = endPosition;
            this.EndRotation  = endRotation;
            this.BackModulePosition = backModulePosition;
            this.IsAllowed    = isAllowed;
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
         * VehicleId Değerini barındırır.
         *
         
         *
         */
        public string VehicleId { get; set; }

        /**
         *
         * Vehicle Değerini barındırır.
         *
         
         *
         */
        public GameObject Vehicle { get; set; }

        /**
         *
         * MoonpoolType Değerini barındırır.
         *
         
         *
         */
        public TechType MoonpoolType { get; set; }

        /**
         *
         * BackModulePosition Değerini barındırır.
         *
         
         *
         */
        public Vector3 BackModulePosition { get; set; }

        /**
         *
         * EndPosition Değerini barındırır.
         *
         
         *
         */
        public Vector3 EndPosition { get; set; }

        /**
         *
         * EndRotation Değerini barındırır.
         *
         
         *
         */
        public Quaternion EndRotation { get; set; }

        /**
         *
         * IsAllowed Değerini barındırır.
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}