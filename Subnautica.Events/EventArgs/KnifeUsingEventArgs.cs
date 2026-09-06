namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class KnifeUsingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public KnifeUsingEventArgs(VFXEventTypes vFXEventType, Vector3 targetPosition, Vector3 orientation, VFXSurfaceTypes surfaceType, VFXSurfaceTypes soundSurfaceType, bool isUnderwater)
        {
            this.VFXEventType     = vFXEventType;
            this.TargetPosition   = targetPosition;
            this.Orientation      = orientation;
            this.SurfaceType      = surfaceType;
            this.SoundSurfaceType = soundSurfaceType;
            this.IsUnderwater     = isUnderwater;
        }
        
        /**
         *
         * VFXEventType Değeri
         *
         
         *
         */
        public VFXEventTypes VFXEventType { get; set; }
        
        /**
         *
         * TargetPosition Değeri
         *
         
         *
         */
        public Vector3 TargetPosition { get; set; }
        
        /**
         *
         * Orientation Değeri
         *
         
         *
         */
        public Vector3 Orientation { get; set; }
                
        /**
         *
         * SurfaceType Değeri
         *
         
         *
         */
        public VFXSurfaceTypes SurfaceType { get; set; }
                
        /**
         *
         * SoundSurfaceType Değeri
         *
         
         *
         */
        public VFXSurfaceTypes SoundSurfaceType { get; set; }

        /**
         *
         * IsUnderwater Değeri
         *
         
         *
         */
        public bool IsUnderwater { get; set; }
    }
}
