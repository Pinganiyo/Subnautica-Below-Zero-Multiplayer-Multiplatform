namespace Subnautica.API.Features.Creatures.MonoBehaviours
{ 
    public class GlowWhaleMonoBehaviour : BaseMultiplayerCreature
    {
        /**
         *
         * Balina sınıfını barındırır.
         *
         
         *
         */
        private global::GlowWhale GlowWhale { get; set; }

        /**
         *
         * Sınıf uyanırken tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.GlowWhale = this.GetComponent<global::GlowWhale>();
        }

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public void Update()
        {
            if (this.MultiplayerCreature.CreatureItem.IsNotMine())
            {
                this.GlowWhale.Update();
            }
        }
    }
}
