namespace Subnautica.Client.Multiplayer.Vehicles
{
    using Subnautica.API.Extensions;

    public class MapRoomCamera : VehicleController
    {
        /**
         *
         * SpyPenguin aracını barındırır.
         *
         
         *
         */
        private global::MapRoomCamera Camera { get; set; }

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
                this.Camera = this.Management.Vehicle.GetComponent<global::MapRoomCamera>();
                this.Camera.rigidBody.SetKinematic();
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
            this.Management.Player.SetUsingRoomId(null);

            if (this.Management.Vehicle)
            {
                this.Camera.engineSound.Stop();
                this.Camera = null;
            }

            base.OnExitVehicle();
        }
    }
}