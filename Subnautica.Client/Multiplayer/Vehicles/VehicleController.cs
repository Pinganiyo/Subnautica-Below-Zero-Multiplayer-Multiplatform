namespace Subnautica.Client.Multiplayer.Vehicles
{
    using Subnautica.API.Extensions;
    using Subnautica.API.Features;
    using Subnautica.Client.Extensions;
    using Subnautica.Client.MonoBehaviours.Player;
    using Subnautica.Network.Models.Server;
    using Subnautica.Network.Structures;

    using UnityEngine;

    public class VehicleController
    {
        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public virtual void OnAwake(PlayerVehicleManagement management)
        {
            this.Management = management;
        }

        /**
         *
         * Bileşen verisi alındığında yapar.
         *
         
         *
         */
        public virtual void OnComponentDataReceived(VehicleUpdateComponent component)
        {

        }

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public virtual void OnUpdate()
        {
            if (this.IsDefaultInterpolate)
            {
                this.InterpolateVehicle();
            }
        }

        /**
         *
         * Her sabit karede tetiklenir.
         *
         
         *
         */
        public virtual void OnFixedUpdate()
        {

        }

        /**
         *
         * Oyuncu araca bindiğinde tetiklenir.
         *
         
         *
         */
        public virtual void OnEnterVehicle()
        {
            if (this.Management.Player != null && this.Management.VehicleUniqueId.IsNotNull())
            {
                this.Management.Player.ResetCinematicsByUniqueId(this.Management.VehicleUniqueId);
                this.Management.Player.ResetCinematics();
            }

            if (this.Management.Vehicle)
            {
                if (this.Management.Vehicle.TryGetComponent<EcoTarget>(out var ecoTarget))
                {
                    ecoTarget.enabled = true;
                }

                if (this.Management.Vehicle.TryGetComponent<WorldForces>(out var worldForces))
                {
                    worldForces.enabled = false;
                }

                if (this.Management.Vehicle.TryGetComponent<global::PingInstance>(out var pingInstance))
                {
                    pingInstance.SetVisible(false);
                }
            }
        }

        /**
         *
         * Oyuncu araçtan indiğinde tetiklenir.
         *
         
         *
         */
        public virtual void OnExitVehicle()
        {
            if (this.Management.Vehicle)
            {
                if (this.Management.Vehicle.TryGetComponent<EcoTarget>(out var ecoTarget))
                {
                    ecoTarget.enabled = false;
                }

                if (this.Management.Vehicle.TryGetComponent<WorldForces>(out var worldForces))
                {
                    worldForces.enabled = true;
                }

                if (this.Management.Vehicle.TryGetComponent<global::PingInstance>(out var pingInstance))
                {
                    pingInstance.SetVisible(true);
                }
            }

            this.SetPlayerParent(null);
        }

        /**
         *
         * Oyuncu araçtan indiğinde tetiklenir.
         *
         
         *
         */
        public bool SetPlayerParent(Transform transform)
        {
            if (this.Management.Player == null || this.Management.Player.PlayerModel == null)
            {
                return false;
            }

            if (transform)
            {
                this.Management.Player.PlayerModel.transform.parent        = transform;
                this.Management.Player.PlayerModel.transform.localPosition = Vector3.zero;
                this.Management.Player.PlayerModel.transform.localRotation = Quaternion.identity;
            }
            else
            {
                this.Management.Player.PlayerModel.transform.parent = null;
                this.Management.Player.PlayerModel.transform.localScale = Vector3.one;
            }

            if (this.Management.Player.PlayerModel.TryGetComponent<Rigidbody>(out var rigidbody))
            {
                rigidbody.SetInterpolation(RigidbodyInterpolation.None);
                rigidbody.SetKinematic();
            }

            return true;
        }

        /**
         *
         * Interpolasyon yapar.
         *
         
         *
         */
        public virtual void InterpolateVehicle()
        {
            if (this.Management.Vehicle)
            {
                if (this.GetDistance() > 100f)
                {
                    this.Management.Vehicle.transform.position = this.Management.Player.VehiclePosition;
                    this.Management.Vehicle.transform.rotation = this.Management.Player.VehicleRotation;
                }
                else
                {
                    this.Management.Vehicle.transform.position = Vector3.SmoothDamp(this.Management.Vehicle.transform.position, this.Management.Player.VehiclePosition, ref this.VehicleVelocity, 0.1f);
                    this.Management.Vehicle.transform.rotation = BroadcastInterval.QuaternionSmoothDamp(this.Management.Vehicle.transform.rotation, this.Management.Player.VehicleRotation, ref this.VehicleRotationVelocity, 0.1f);
                }

                this.Management.Player.SetVelocity(this.VehicleVelocity);
            }
        }

        /**
         *
         * Uzaklığı döner.
         *
         
         *
         */
        public float GetDistance()
        {
            return ZeroVector3.Distance(this.Management.Vehicle.transform.position, this.Management.Player.VehiclePosition);
        }

        /**
         *
         * Mevcut hızı döner.
         *
         
         *
         */
        public Vector3 GetVelocity()
        {
            return this.VehicleVelocity;
        }

        /**
         *
         * Management Değeri
         *
         
         *
         */
        public PlayerVehicleManagement Management { get; set; }

        /**
         *
         * IsDefaultInterpolate Değeri
         *
         
         *
         */
        public bool IsDefaultInterpolate { get; set; } = true;

        /**
         *
         * En sonki hız değerleri
         *
         
         *
         */
        public Vector3 VehicleVelocity = Vector3.zero;

        /**
         *
         * En sonki hız değerleri
         *
         
         *
         */
        public Quaternion VehicleRotationVelocity;
    }
}
