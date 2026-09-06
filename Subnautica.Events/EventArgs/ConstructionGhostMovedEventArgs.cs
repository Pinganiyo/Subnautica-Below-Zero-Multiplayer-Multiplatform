namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Extensions;
    using Subnautica.API.Features;

    using UnityEngine;

    public class ConstructionGhostMovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructionGhostMovedEventArgs(GameObject ghostModel, TechType techType, Transform aimTranform, bool isCanPlace, int lastRotation)
        {
            this.GhostModel      = ghostModel;
            this.UniqueId        = ghostModel.GetIdentityId(true);
            this.TechType        = techType;
            this.Position        = ghostModel.transform.position;
            this.Rotation        = ghostModel.transform.rotation;
            this.AimTransform    = aimTranform;
            this.IsCanPlace      = isCanPlace;
            this.UpdatePlacement = Network.Temporary.GetProperty<bool>(ghostModel.GetIdentityId(), "UpdatePlacementResult");
            this.LastRotation    = lastRotation;
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
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

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
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * IsCanPlace Değeri
         *
         
         *
         */
        public bool IsCanPlace { get; private set; }

        /**
         *
         * UpdatePlacement Değeri
         *
         
         *
         */
        public bool UpdatePlacement { get; private set; }

        /**
         *
         * Son Açı Değeri
         *
         
         *
         */
        public int LastRotation { get; private set; }
    }
}
