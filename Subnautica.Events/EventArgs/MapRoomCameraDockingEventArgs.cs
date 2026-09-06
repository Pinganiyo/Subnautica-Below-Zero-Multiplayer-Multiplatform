namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class MapRoomCameraDockingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public MapRoomCameraDockingEventArgs(string uniqueId, string vehicleId, Vector3 endPosition, Quaternion endRotation, bool isLeft, bool isAllowed = true)
        {
            this.UniqueId    = uniqueId;
            this.VehicleId   = vehicleId;
            this.EndPosition = endPosition;
            this.EndRotation = endRotation;
            this.IsLeft      = isLeft;
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
         * VehicleId değeri
         *
         
         *
         */
        public string VehicleId { get; set; }

        /**
         *
         * EndPosition değeri
         *
         
         *
         */
        public Vector3 EndPosition { get; set; }

        /**
         *
         * EndRotation değeri
         *
         
         *
         */
        public Quaternion EndRotation { get; set; }

        /**
         *
         * IsLeft değeri
         *
         
         *
         */
        public bool IsLeft { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
