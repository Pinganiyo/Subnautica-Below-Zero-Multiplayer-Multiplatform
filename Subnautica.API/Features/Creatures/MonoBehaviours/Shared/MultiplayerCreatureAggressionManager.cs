namespace Subnautica.API.Features.Creatures.MonoBehaviours.Shared
{
    public class MultiplayerCreatureAggressionManager : BaseMultiplayerCreature
    {
        /**
         *
         * CreatureAggressionManager değerini barındırır.
         *
         
         *
         */
        public global::CreatureAggressionManager CreatureAggressionManager { get; private set; }

        /**
         *
         * Sınıf uyanırken tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.CreatureAggressionManager = this.GetComponent<global::CreatureAggressionManager>();
        }

        /**
         *
         * Aktif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnEnable()
        {
            this.OnChangedOwnership();
        }

        /**
         *
         * Sahiplik değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnChangedOwnership()
        {
            this.CancelInvokes();

            if (this.MultiplayerCreature.CreatureItem.IsMine())
            {
                this.CreatureAggressionManager.EnableAggressionToFish();
                this.CreatureAggressionManager.EnableAggressionToSharks();
            }
        }

        /**
         *
         * İşlemler iptal ederç
         *
         
         *
         */
        private void CancelInvokes()
        {
            if (this.CreatureAggressionManager.aggressionToSharksPaused)
            {
                this.CreatureAggressionManager.CancelInvoke("EnableAggressionToSharks");
            }

            if (this.CreatureAggressionManager.aggressionToFishPaused)
            {
                this.CreatureAggressionManager.CancelInvoke("EnableAggressionToFish");
            }
        }
    }
}
