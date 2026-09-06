namespace Subnautica.Client.Multiplayer.Cinematics
{
    using Subnautica.Client.MonoBehaviours.Player;

    public class UseableDiveHatchCinematic : CinematicController
    {
        /**
         *
         * Kapıyı barındırır.
         *
         
         *
         */
        private global::UseableDiveHatch UseableDiveHatch { get; set; }

        /**
         *
         * Animasyonu resetler.
         *
         
         *
         */
        public override void OnResetAnimations(PlayerCinematicQueueItem item)
        {
            this.UseableDiveHatch = this.Target.GetComponentInChildren<global::UseableDiveHatch>();
            this.UseableDiveHatch.enterCinematicController.animator.Rebind();
            this.UseableDiveHatch.exitCinematicController.animator.Rebind();
        }

        /**
         *
         * Binme animasyonunu başlatır.
         *
         
         *
         */
        public void EnterStartCinematic()
        {
            if (this.UseableDiveHatch.enterCinematicController.name.Contains("Drop_Pod"))
            {
                this.ZeroPlayer.SetInteriorId(this.UniqueId);
            }
            else
            {
                this.ZeroPlayer.SetSubRootId(this.UniqueId);
            }

            this.SetCinematic(this.UseableDiveHatch.enterCinematicController);
            this.StartCinematicMode();
        }

        /**
         *
         * İnme animasyonunu başlatır.
         *
         
         *
         */
        public void ExitStartCinematic()
        {
            if (this.UseableDiveHatch.exitCinematicController.playerViewAnimationName.Contains("surfacebasedoor_"))
            {
                this.SetCinematic(this.UseableDiveHatch.exitCinematicController, isFastInterpolation: false, isSkipFirstAnimation: false);
            }
            else
            {
                this.SetCinematic(this.UseableDiveHatch.exitCinematicController, isFastInterpolation: false, isSkipFirstAnimation: true);
            }

            this.StartCinematicMode();
        }
    }
}
