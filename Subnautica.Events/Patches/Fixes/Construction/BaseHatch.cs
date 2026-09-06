namespace Subnautica.Events.Patches.Fixes.Construction
{
    using HarmonyLib;

    using UnityEngine;

    using Subnautica.API.Features;

    [HarmonyPatch(typeof(global::UseableDiveHatch), nameof(global::UseableDiveHatch.OnHandClick))]
    public class BaseHatch
    {
        private static void Prefix(global::UseableDiveHatch __instance)
        {
            if (Network.IsMultiplayerActive && __instance.enabled)
            {
                __instance.gameObject.EnsureComponent<FixBaseHatch>();
            }
        }
    }

    public class FixBaseHatch : MonoBehaviour
    {
        /**
         *
         * Kapağı yamalar.
         *
         
         *
         */
        private global::UseableDiveHatch Hatch { get; set; }

        /**
         *
         * Oyuncuyu barındırır.
         *
         
         *
         */
        private global::Player Player { get; set; }

        /**
         *
         * Uyanırken tetiklenir.
         *
         
         *
         */        
        public void Awake()
        {
            this.Hatch  = this.gameObject.GetComponent<global::UseableDiveHatch>();
            this.Player = global::Player.main;
        }

        /**
         *
         * Pasif hale gelirken tetiklenir.
         *
         
         *
         */  
        public void OnDisable()
        {
            if (global::PlayerCinematicController.cinematicModeCount > 0)
            {
                if (this.Hatch && this.Hatch.enterCinematicController.cinematicModeActive)
                {
                    this.FastEnter();
                }

                if (this.Hatch && this.Hatch.exitCinematicController.cinematicModeActive)
                {
                    this.FastExit();
                }
            }
        }

        /**
         *
         * Hızlı giriş işlemini yapar.
         *
         
         *
         */  
        private void FastEnter()
        {
            if (this.Hatch)
            {
                this.Player.SetPosition(this.Hatch.GetInsideSpawnPosition());

                EnterExitHelper.Enter(this.Hatch.gameObject, this.Player);
            }
        }

        /**
         *
         * Hızlı çıkış işlemini yapar.
         *
         
         *
         */  
        private void FastExit()
        {
            if (this.Hatch && this.Hatch.GetExitPosition(out var exitPosition))
            {
                this.Player.SetPosition(exitPosition);

                EnterExitHelper.Exit(this.Hatch.transform, this.Player, this.Hatch.isForWaterPark);
            }
        }
    }
}
