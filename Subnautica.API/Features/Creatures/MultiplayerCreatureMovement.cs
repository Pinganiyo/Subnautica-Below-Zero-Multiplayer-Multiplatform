namespace Subnautica.API.Features.Creatures
{
    using Subnautica.API.Features;
    using Subnautica.Network.Structures;

    using UnityEngine;

    public class MultiplayerCreatureMovement
    {
        /**
         *
         * Balık hareket ediyor mu?
         *
         
         *
         */
        public bool IsDriving = false;

        /**
         *
         * Enterpolasyon Zamanını barındırır.
         *
         
         *
         */
        private float InterpolationTime = 0f;

        /**
         *
         * Hedef Pozisyonu barındırır.
         *
         
         *
         */
        private Vector3 TargetPosition { get; set; }

        /**
         *
         * Hedef Açıyı barındırır.
         *
         
         *
         */
        private Quaternion TargetRotation { get; set; }

        /**
         *
         * Creature değeri
         *
         
         *
         */
        private MultiplayerCreature Creature { get; set; }

        /**
         *
         * Hızı Barındırır.
         *
         
         *
         */
        private Vector3 Velocity;

        /**
         *
         * Konum Açı Hızını Barındırır.
         *
         
         *
         */
        private Quaternion RotationVelocity;

        /**
         *
         * Sınıf ayarlarını yapar.
         *
         
         *
         */
        public MultiplayerCreatureMovement(MultiplayerCreature creature)
        {
            this.Creature = creature;
        }

        /**
         *
         * Verileri temizler.
         *
         
         *
         */
        public void ResetCreature()
        {
            this.IsDriving = false;
            this.InterpolationTime = 0f;
            this.Creature.Locomotion.ResetUpDirectionOvverride();
        }

        /**
         *
         * Yaratık hedef konuma yüzmeye başlar.
         *
         
         *
         */
        public void SwimTo(Vector3 targetPosition, Quaternion targetRotation)
        {
            this.IsDriving         = true;
            this.TargetPosition    = targetPosition;
            this.TargetRotation    = targetRotation;
            this.InterpolationTime = (this.Creature.CreatureItem.Data.IsFastSyncActivated ? 0.1f : 0.2f) + 0.05f;
        }

        /**
         *
         * Yaratığı hareket ettirir.
         *
         
         *
         */
        public bool SimpleMoveV2()
        {
            if (!this.IsDriving || !this.Creature.IsActive)
            {
                return false;
            }

            if (this.GetTargetDistance() > 750f || this.InterpolationTime <= 0.001f)
            {
                this.StopMovement();
            }
            else
            {
                this.Creature.GameObject.transform.position = Vector3.SmoothDamp(this.Creature.GameObject.transform.position, this.TargetPosition, ref this.Velocity, this.InterpolationTime);
                this.Creature.GameObject.transform.rotation = BroadcastInterval.QuaternionSmoothDamp(this.Creature.GameObject.transform.rotation, this.TargetRotation, ref this.RotationVelocity, this.InterpolationTime);

                this.Creature.Rigidbody.velocity = this.Velocity;
            }

            return true;
        }

        /**
         *
         * Yaratığı hareket ettirir. (OLD/Draft)
         *
         
         *
         */
        public bool SimpleMove()
        {
            if (!this.IsDriving || !this.Creature.IsActive)
            {
                return false;
            }

            if (this.GetTargetDistance() > 750f || this.InterpolationTime <= 0.001f)
            {
                this.StopMovement();
            }
            else
            {
                this.Creature.Rigidbody.velocity = this.GetVelocity();
            }

            this.InterpolationTime -= Time.fixedDeltaTime;

            return true;
        }

        /**
         *
         * Yaratığı döndürür.
         *
         
         *
         */
        public bool SimpleRotate()
        {
            if (!this.IsDriving || !this.Creature.IsActive)
            {
                return false;
            }

            this.Creature.Rigidbody.angularVelocity = Vector3.zero;

            return true;
        }

        /**
         *
         * Hareketi durdurur.
         *
         
         *
         */
        private void StopMovement(bool movePosition = true)
        {
            this.Creature.Rigidbody.velocity        = Vector3.zero;
            this.Creature.Rigidbody.angularVelocity = Vector3.zero;

            if (movePosition)
            {
                this.Creature.Rigidbody.MovePosition(this.TargetPosition);
            }

            this.IsDriving         = false;
            this.InterpolationTime = 0f;
            this.TargetPosition    = Vector3.zero;
        }
        
        /**
         *
         * Hedef Mesafesini döner.
         *
         
         *
         */
        private float GetTargetDistance()
        {
            return ZeroVector3.Distance(this.TargetPosition, this.Creature.Rigidbody.transform.position);
        }

        /**
         *
         * Hızı döner.
         *
         
         *
         */
        private Vector3 GetVelocity()
        {
            return (this.TargetPosition - this.Creature.Rigidbody.transform.position) / this.InterpolationTime;
        }
    }
}