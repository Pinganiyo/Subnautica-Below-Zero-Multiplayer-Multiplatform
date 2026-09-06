namespace Subnautica.API.MonoBehaviours
{
    using UnityEngine;

    using Subnautica.API.Features;

    public class BaseGhostRotationComponent : MonoBehaviour
    {
        /**
         *
         * LastRotation değerini barındırır.
         *
         
         *
         */
        public int LastRotation { get; private set; } = 0;

        /**
         *
         * LastRotation veriyi günceller.
         *
         
         *
         */
        public void SetLastRotation(int lastRotation)
        {
            this.LastRotation = lastRotation;
        }

        /**
         *
         * ClampRotation İşlevini çalıştırır.
         *
         
         *
         */
        public static void ClampRotation(BaseGhost baseGhost, int max)
        {
            if (BaseGhostRotationComponent.GetComponentLastRotation(baseGhost) == -1)
            {
                global::Builder.ClampRotation(max);
            }
        }

        /**
         *
         * UpdateRotation İşlevini çalıştırır.
         *
         
         *
         */
        public static bool UpdateRotation(BaseGhost baseGhost, int max)
        {
            if (BaseGhostRotationComponent.GetComponentLastRotation(baseGhost) == -1)
            {
                return global::Builder.UpdateRotation(max);
            }

            return true;
        }

        /**
         *
         * GetLastRotation İşlevini çalıştırır.
         *
         
         *
         */
        public static int GetLastRotation(BaseGhost baseGhost)
        {
            int lastRotation = BaseGhostRotationComponent.GetComponentLastRotation(baseGhost);
            return lastRotation == -1 ? global::Builder.lastRotation : lastRotation;
        }

        /**
         *
         * Hayalet modelin sahibi ben miyim kontrolü yapar.
         *
         
         *
         */
        private static int GetComponentLastRotation(BaseGhost baseGhost)
        {
            if (!Network.IsMultiplayerActive)
            {
                return -1;
            }

            if (baseGhost.TryGetComponent<BaseGhostRotationComponent>(out var component))
            {
                return component.LastRotation;
            }

            return -1;
        }
    }
}