namespace Subnautica.API.Features.Creatures.MonoBehaviours
{
    using Subnautica.Network.Structures;

    using UnityEngine;

    public class SkyrayMonoBehaviour : BaseMultiplayerCreature
    {
        /**
         *
         * Balina sınıfını barındırır.
         *
         
         *
         */
        private global::Skyray Skyray { get; set; }

        /**
         *
         * Sınıf uyanırken tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.Skyray = this.GetComponent<global::Skyray>();
        }

        /**
         *
         * Her sabit karede tetiklenir.
         *
         
         *
         */
        public void FixedUpdate()
        {
            if (!this.MultiplayerCreature.CreatureItem.IsMine())
            {
                if (this.IsRoosting())
                {
                    this.Skyray.GetAnimator().SetBool("roosting", true);
                    this.Skyray.GetAnimator().SetBool("flapping", false);
                }
                else
                {
                    if (this.Skyray.GetAnimator().GetBool("roosting"))
                    {
                        this.Skyray.GetAnimator().SetBool("roosting", false);
                        this.Skyray.GetAnimator().SetBool("flapping", true);
                    }
                }
            }
        }


        /**
         *
         * Kuş tünemiş mi?
         *
         
         *
         */
        private bool IsRoosting()
        {
            return ZeroVector3.Distance(this.MultiplayerCreature.Creature.leashPosition, this.transform.position) <= 0.03f;
        }
    }
}
