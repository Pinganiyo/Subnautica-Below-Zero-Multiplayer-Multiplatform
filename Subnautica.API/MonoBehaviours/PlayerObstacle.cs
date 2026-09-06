namespace Subnautica.API.MonoBehaviours
{
    using UnityEngine;

    public class PlayerObstacle : MonoBehaviour, IObstacle
    {
        /**
         *
         * Çarpışma olduğunda yıkılabilsin mi?
         *
         
         *
         */
        public bool CanDeconstruct(out string reason)
        {
            reason = global::Language.main.Get("PlayerObstacle");
            return false;
        }

        /**
         *
         * Çarpışmayı göz ardı edilsin mi?
         *
         
         *
         */
        public bool IsDeconstructionObstacle()
        {
            return true;
        }
    }
}
