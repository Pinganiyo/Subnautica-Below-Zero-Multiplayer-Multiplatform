namespace Subnautica.API.Features.Creatures.MonoBehaviours.Shared
{
    public class MultiplayerCreaturedShared : BaseMultiplayerCreature
    {
        /**
         *
         * FrozenMixin değerini barındırır.
         *
         
         *
         */
        public global::CreatureFrozenMixin FrozenMixin { get; private set; }

        /**
         *
         * Sınıf uyanırken tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.FrozenMixin = this.GetComponent<global::CreatureFrozenMixin>();
        }

        /**
         *
         * Sahiplik değiştiğinde tetiklenir.
         *
         
         *
         */
        public void OnChangedOwnership()
        {
            if (this.FrozenMixin != null && this.FrozenMixin.IsFrozen() && this.MultiplayerCreature.CreatureItem.IsMine())
            {
                this.FrozenMixin.FreezeForTime(4f);
            }
        }
    }
}
