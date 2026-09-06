namespace Subnautica.Client.MonoBehaviours.Vehicle
{
    using Subnautica.API.Features;
    using Subnautica.Client.MonoBehaviours.Player;

    using UnityEngine;

    public class MultiplayerSeaTruckSleeperModule : MonoBehaviour
    {
        /**
         *
         * Yatağı barındırır.
         *
         
         *
         */
        private global::Bed Bed;

        /**
         *
         * Nesne başlatılırken tetiklenir.
         *
         
         *
         */
        public void Start()
        {
            this.Bed = this.GetComponentInChildren<global::Bed>(true);
        }

        /**
         *
         * Oyuncu çıktığında tetiklenir.
         *
         
         *
         */
        public void OnMultiplayerPlayerDisconnected(ZeroPlayer player)
        {
            if (this.IsSamePlayer(this.GetPlayer(), player))
            {
                this.Bed.animator.Rebind();
            }
        }

        /**
         *
         * Nesne yok edilirken tetiklenir.
         *
         
         *
         */
        public void OnDestroy()
        {
            var player = this.GetPlayer();
            if (player != null)
            {
                Multiplayer.Furnitures.Bed.ClearBed(player.UniqueId);

                player.SetParent(null);
                player.Animator.Rebind();
            }
        }

        /**
         *
         * Aynı oyuncu mu?
         *
         
         *
         */
        private bool IsSamePlayer(ZeroPlayer player1, ZeroPlayer player2)
        {
            return player1 != null && player2 != null && player1.UniqueId == player2.UniqueId;
        }

        /**
         *
         * Yataktaki oyuncuyu döner.
         *
         
         *
         */
        private ZeroPlayer GetPlayer()
        {
            return this.Bed.GetComponentInChildren<PlayerAnimation>()?.Player;
        }
    }
}
