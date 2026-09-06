namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class ConstructionGhostTryPlacingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructionGhostTryPlacingEventArgs(GameObject ghostModel,string uniqueId, string subrootId, TechType techType, int lastRotation, Vector3 position, Quaternion rotation, Transform aimTranform, bool isCanPlace, bool isBasePiece, bool isError, bool isAllowed = true)
        {
            this.GhostModel   = ghostModel;
            this.UniqueId     = uniqueId;
            this.SubrootId    = subrootId;
            this.TechType     = techType;
            this.LastRotation = lastRotation;
            this.Position     = position;
            this.Rotation     = rotation;
            this.AimTransform = aimTranform;
            this.IsCanPlace   = isCanPlace;
            this.IsBasePiece  = isBasePiece;
            this.IsError      = isError;
            this.IsAllowed    = isAllowed;
        }

        /**
         *
         * GhostModel
         *
         
         *
         */
        public GameObject GhostModel { get; private set; }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        public string SubrootId { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * LastRotation Değeri
         *
         
         *
         */
        public int LastRotation { get; private set; }

        /**
         *
         * Position Değeri
         *
         
         *
         */
        public Vector3 Position { get; private set; }

        /**
         *
         * Rotation Değeri
         *
         
         *
         */
        public Quaternion Rotation { get; private set; }

        /**
         *
         * AimTransform Değeri
         *
         
         *
         */
        public Transform AimTransform { get; private set; }

        /**
         *
         * IsCanPlace Değeri
         *
         
         *
         */
        public bool IsCanPlace { get; private set; }

        /**
         *
         * IsBasePiece Değeri
         *
         
         *
         */
        public bool IsBasePiece { get; private set; }

        /**
         *
         * IsError Değeri
         *
         
         *
         */
        public bool IsError { get; private set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
