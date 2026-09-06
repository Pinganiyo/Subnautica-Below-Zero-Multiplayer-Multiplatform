namespace Subnautica.Client.Multiplayer.Vehicles
{
    using Subnautica.API.Extensions;
    using Subnautica.Client.Extensions;

    public class SeaTruck : VehicleController
    {
        /**
         *
         * SeaTruck aracını barındırır.
         *
         
         *
         */
        private global::SeaTruckMotor Vehicle { get; set; }

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public override void OnUpdate()
        {
            base.OnUpdate();

            if (this.Vehicle)
            {
                this.UpdateSounds();
            }
        }

        /**
         *
         * Her sabit karede tetiklenir.
         *
         
         *
         */
        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();

            if (!this.Vehicle.ecoTarget.enabled)
            {
                ErrorMessage.AddMessage("FALSE ECO TARGET!");
            }
        }

        /**
         *
         * Araç seslerini ayarlar
         *
         
         *
         */
        private void UpdateSounds()
        {
            // 32 December 2099
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
                this.Vehicle = this.Management.Vehicle.GetComponent<global::SeaTruckMotor>();
                this.Vehicle.truckSegment.GetFirstSegment().rb.SetKinematic();

                this.SetPlayerParent(this.Vehicle.pilotPosition.transform);

                if (this.Management.VehicleUniqueId.IsNotNull())
                {
                    this.Management.Player.SeaTruckStartPilotingCinematic(this.Management.VehicleUniqueId);
                }
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
            if (this.Management.Vehicle)
            {
                this.Vehicle = null;
            }

            if (this.Management.VehicleUniqueId.IsNotNull())
            {
                this.Management.Player.SeaTruckStopPilotingCinematic(this.Management.VehicleUniqueId);
            }

            base.OnExitVehicle();
        }
    }
}
