namespace Subnautica.API.MonoBehaviours.Components
{
    using UnityEngine;

    public class BasePieceData
    {
        /**
         *
         * Position Değeri
         *
         
         *
         */
        public Vector3 Position { get; set; }

        /**
         *
         * LocalPosition Değeri
         *
         
         *
         */
        public Vector3 LocalPosition { get; set; }

        /**
         *
         * LocalRotation Değeri
         *
         
         *
         */
        public Quaternion LocalRotation { get; set; }

        /**
         *
         * Transform Değeri
         *
         
         *
         */
        public Transform CurrentTransform { get; set; }

        /**
         *
         * FaceDirection Değeri
         *
         
         *
         */
        public Base.Direction FaceDirection { get; set; }

        /**
         *
         * FaceType Değeri
         *
         
         *
         */
        public Base.FaceType FaceType { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; } = TechType.None;

        /**
         *
         * Karşılaştırma Yapar
         *
         
         *
         */
        public override bool Equals(System.Object obj)
        {
            BasePieceData basePieceData = obj as BasePieceData;
            if (basePieceData is null)
            {
                return false;
            }

            return basePieceData.Position == this.Position && basePieceData.LocalPosition == this.LocalPosition && basePieceData.LocalRotation == this.LocalRotation && basePieceData.FaceDirection == this.FaceDirection && basePieceData.FaceType == this.FaceType && basePieceData.TechType == this.TechType;
        }

        /**
         *
         * Karşılaştırma Yapar
         *
         
         *
         */
        public override int GetHashCode()
        {
            return (this.Position, this.LocalPosition, this.LocalRotation, this.FaceDirection, this.FaceType).GetHashCode();
        }
    }
}
