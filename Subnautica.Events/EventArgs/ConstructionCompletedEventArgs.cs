namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class ConstructionCompletedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructionCompletedEventArgs(string uniqueId, string baseId, TechType techType, Vector3 cellPosition, bool isFaceHasValue = false, Vector3 localPosition = new Vector3(), Quaternion localRotation = new Quaternion(), Base.Direction faceDirection = Base.Direction.North, Base.FaceType faceType = Base.FaceType.None)
        {
            this.UniqueId       = uniqueId;
            this.BaseId         = baseId;
            this.TechType       = techType;
            this.CellPosition   = cellPosition;
            this.IsFaceHasValue = isFaceHasValue;
            this.LocalPosition  = localPosition;
            this.LocalRotation  = localRotation;
            this.FaceDirection  = faceDirection;
            this.FaceType       = faceType;
        }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * Base Kimliği
         *
         
         *
         */
        public string BaseId { get; private set; }
        
        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * CellPosition Değeri
         *
         
         *
         */
        public Vector3 CellPosition { get; private set; }

        /**
         *
         * IsFaceHasValue Değeri
         *
         
         *
         */
        public bool IsFaceHasValue { get; private set; }

        /**
         *
         * LocalPosition Değeri
         *
         
         *
         */
        public Vector3 LocalPosition { get; private set; }

        /**
         *
         * LocalRotation Değeri
         *
         
         *
         */
        public Quaternion LocalRotation { get; private set; }

        /**
         *
         * FaceDirection Değeri
         *
         
         *
         */
        public Base.Direction FaceDirection { get; private set; }

        /**
         *
         * FaceType Değeri
         *
         
         *
         */
        public Base.FaceType FaceType { get; private set; }
    }
}
