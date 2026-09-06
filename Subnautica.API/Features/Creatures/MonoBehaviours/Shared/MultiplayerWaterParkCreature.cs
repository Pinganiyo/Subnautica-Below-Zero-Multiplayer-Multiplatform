namespace Subnautica.API.Features.Creatures.MonoBehaviours.Shared
{
    using Subnautica.API.Enums;
    using Subnautica.API.Extensions;

    using UnityEngine;

    public class MultiplayerWaterParkCreature : BaseMultiplayerCreature
    {
        /**
         *
         * WaterParkCreature sınıfını barındırır.
         *
         
         *
         */
        private global::WaterParkCreature WaterParkCreature { get; set; }

        /**
         *
         * IsRegisteredWaterPark sınıfını barındırır.
         *
         
         *
         */
        private bool IsRegisteredWaterPark { get; set; }

        /**
         *
         * Sınıf uyanırken tetiklenir.
         *
         
         *
         */
        public void Awake()
        {
            this.WaterParkCreature = this.GetComponent<global::WaterParkCreature>();
        }

        /**
         *
         * Başlarken tetiklenir.
         *
         
         *
         */
        public void Start()
        {
            this.HideCreature();
        }

        /**
         *
         * Aktif olurken tetiklenir.
         *
         
         *
         */
        public void OnEnable()
        {
            this.HideCreature();
        }

        /**
         *
         * Her sabit karede tetiklenir.
         *
         
         *
         */
        public void FixedUpdate()
        {
            if (this.IsRegisteredWaterPark == false)
            {
                this.RegisterWaterPark();
            }
            // this.MultiplayerCreature.CreatureItem.Component
        }

        /**
         *
         * Yaratık waterPark kaydını yapar.
         *
         
         *
         */
        private void RegisterWaterPark()
        {
            this.IsRegisteredWaterPark = true;
        }

        /**
         *
         * Yaratığı gizler.
         *
         
         *
         */
        private void HideCreature()
        {
            this.gameObject.transform.localScale = Vector3.zero;
        }
    }
}
