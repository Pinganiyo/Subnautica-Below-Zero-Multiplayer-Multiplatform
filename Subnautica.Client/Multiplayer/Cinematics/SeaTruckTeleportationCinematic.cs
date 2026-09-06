namespace Subnautica.Client.Multiplayer.Cinematics
{
    using Subnautica.API.Extensions;
    using Subnautica.Client.MonoBehaviours.Player;

    public class SeaTruckTeleportationCinematic : CinematicController
    {
        /**
         *
         * Yatağı barındırır.
         *
         
         *
         */
        private global::SeaTruckTeleporter Teleporter { get; set; }

        /**
         *
         * Animasyonu resetler.
         *
         
         *
         */
        public override void OnResetAnimations(PlayerCinematicQueueItem item)
        {
            this.Teleporter = this.Target.GetComponentInChildren<global::SeaTruckTeleporter>();
        }

        /**
         *
         * Yatma animasyonunu başlatır.
         *
         
         *
         */
        public void SeaTruckTeleportationStartCinematic()
        {
            this.Teleporter.arrivalVFX.Play();

            this.SetCinematic(this.Teleporter.arrivalCinematic);
            this.SetCinematicEndMode(this.TeleportationEnd);
            this.StartCinematicMode();
        }

        /**
         *
         * Işınlanma bittiğinde tetiklenir.
         *
         
         *
         */
        private void TeleportationEnd()
        {
            if (this.Teleporter && this.ZeroPlayer.IsInSeaTruck)
            {
                this.ZeroPlayer.GetComponent<PlayerAnimation>().UpdateIsInSeaTruck(true);
            }
        }
    }
}
