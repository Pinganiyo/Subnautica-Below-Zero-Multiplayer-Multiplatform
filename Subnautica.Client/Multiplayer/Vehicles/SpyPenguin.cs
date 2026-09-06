namespace Subnautica.Client.Multiplayer.Vehicles
{
    using System.Collections.Generic;

    using Subnautica.API.Extensions;
    using Subnautica.Network.Models.Server;

    public class SpyPenguin : VehicleController
    {
        /**
         *
         * SpyPenguin aracını barındırır.
         *
         
         *
         */
        private global::SpyPenguin Penguin { get; set; }

        /**
         *
         * Araç bileşenini barındırır.
         *
         
         *
         */
        private SpyPenguinUpdateComponent VehicleComponent { get; set; }

        /**
         *
         * Animasyon kuyruğunu barındırır.
         *
         
         *
         */
        private List<string> AnimationQueue { get; set; } = new List<string>();

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public override void OnUpdate()
        {
            base.OnUpdate();

            this.PlayAnimations();
        }

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();
            
            if (this.VehicleComponent != null)
            { 
                this.Penguin.animator.SetBool("cam_extended", this.VehicleComponent.IsSelfieMode);

                if (this.VehicleComponent.SelfieNumber == -1)
                {
                    this.Management.Player.ResetSelfieMode();
                }
                else
                {
                    this.Management.Player.SetSelfieMode(this.VehicleComponent.SelfieNumber);
                }
            }
        }

        /**
         *
         * Bileşen verisi alındığında yapar.
         *
         
         *
         */
        public override void OnComponentDataReceived(VehicleUpdateComponent component)
        {
            this.VehicleComponent = component.GetComponent<SpyPenguinUpdateComponent>();

            if (this.VehicleComponent.Animations != null)
            {
                this.AnimationQueue.AddRange(this.VehicleComponent.Animations);
            }
        }

        /**
         *
         * Oyuncu araca bindiğinde tetiklenir.
         *
         
         *
         */
        public override void OnEnterVehicle()
        {
            base.OnEnterVehicle();

            if (this.Management.Vehicle)
            {
                this.Penguin = this.Management.Vehicle.GetComponent<global::SpyPenguin>();
                this.Penguin.rb.SetKinematic();
            }
        }

        /**
         *
         * Oyuncu araçtan indiğinde tetiklenir.
         *
         
         *
         */
        public override void OnExitVehicle()
        {
            this.Management.Player.ResetAnimations();

            if (this.Management.Vehicle)
            {
                this.Penguin.animator.SetBool("cam_extended", false);

                this.Penguin = null;
            }

            base.OnExitVehicle();
        }

        /**
         *
         * Animasyonları oynatır.
         *
         
         *
         */
        private void PlayAnimations()
        {
            if (this.AnimationQueue.Count > 0)
            {
                foreach (var animation in this.AnimationQueue)
                {
                    if (animation.Contains("arm_grab_fail"))
                    {
                        this.Penguin.animator.SetTrigger("arm_grab_fail");
                    }
                    else if (animation.Contains("arm_grab"))
                    {
                        this.Penguin.animator.SetTrigger("arm_grab");
                    }
                    else if (animation.Contains("arm_punch"))
                    {
                        this.Penguin.animator.SetTrigger("arm_punch");
                    }
                }

                this.AnimationQueue.Clear();
            }
        }
    }
}