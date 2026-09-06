namespace Subnautica.API.Features.Creatures.MonoBehaviours.Shared
{
    public class MultiplayerAggressiveToPilotingVehicle : BaseMultiplayerCreature
    {
        /**
         *
         * AggressiveToPilotingVehicle sınıfını barındırır.
         *
         
         *
         */
        private global::AggressiveToPilotingVehicle AggressiveToPilotingVehicle { get; set; }

        /**
         *
         * Sınıf uyanırken tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.AggressiveToPilotingVehicle = this.GetComponent<global::AggressiveToPilotingVehicle>();
        }

        /**
         *
         * Aktifleşirken tetiklenir.
         *
         
         *
         */
        public void OnEnable()
        {
            this.StopUpdateAggression();

            if (this.MultiplayerCreature.CreatureItem.IsMine())
            {
                this.StartUpdateAggression();
            }
        }

        /**
         *
         * Sahiplik değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnChangedOwnership()
        {
            this.StopUpdateAggression();

            if (this.MultiplayerCreature.CreatureItem.IsMine())
            {
                this.StartUpdateAggression();
            }
        }

        /**
         *
         * Pasif olurken tetiklenir.
         *
         
         *
         */
        public void OnDisable()
        {
            this.StopUpdateAggression();
        }

        /**
         *
         * Agresif güncellemeyi durdurur.
         *
         
         *
         */
        private void StopUpdateAggression()
        {
            this.CancelInvoke("MultiplayerUpdateAggression");
        }

        /**
         *
         * Agresif güncellemeyi başlatır.
         *
         
         *
         */
        private void StartUpdateAggression()
        {
            this.InvokeRepeating("MultiplayerUpdateAggression", global::UnityEngine.Random.value * this.AggressiveToPilotingVehicle.updateAggressionInterval, this.AggressiveToPilotingVehicle.updateAggressionInterval);
        }

        /**
         *
         * Agresif güncellemeyi uygular.
         *
         
         *
         */
        private void MultiplayerUpdateAggression()
        {
            var playerInRange = ZeroPlayer.GetPlayersByInRange(this.transform.position, this.AggressiveToPilotingVehicle.range * this.AggressiveToPilotingVehicle.range, true);
            if (playerInRange.IsExistsPlayer())
            {
                this.AggressiveToPilotingVehicle.lastTarget.SetTarget(playerInRange.NearestPlayer.GetVehicle(), this.AggressiveToPilotingVehicle.targetPriority);
                this.AggressiveToPilotingVehicle.creature.Aggression.Add(this.AggressiveToPilotingVehicle.aggressionPerSecond * this.AggressiveToPilotingVehicle.updateAggressionInterval);
            }
        }
    }
}
