namespace Subnautica.API.Features.Creatures.MonoBehaviours
{
    using UnityEngine;

    public class BaseMultiplayerCreature : MonoBehaviour
    {
        /**
         *
         * Çok oyunculu Yaratık sınıfını barındırır.
         *
         
         *
         */
        public MultiplayerCreature MultiplayerCreature { get; private set; }

        /**
         *
         * Çok oyunculu Yaratık sınıfını değiştirir.
         *
         
         *
         */
        public void SetMultiplayerCreature(MultiplayerCreature multiplayerCreature)
        {
            this.MultiplayerCreature = multiplayerCreature;
        }
    }
}
