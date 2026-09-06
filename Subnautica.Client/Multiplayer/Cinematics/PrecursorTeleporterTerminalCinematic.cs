namespace Subnautica.Client.Multiplayer.Cinematics
{
    using System.Collections;

    using Subnautica.API.Extensions;
    using Subnautica.Client.MonoBehaviours.Player;

    using UnityEngine;

    public class PrecursorTeleporterTerminalCinematic : CinematicController
    {
        /**
         *
         * Terminali barındırır.
         *
         
         *
         */
        private global::PrecursorTeleporterActivationTerminal Terminal { get; set; }

        /**
         *
         * Animasyonu resetler.
         *
         
         *
         */
        public override void OnResetAnimations(PlayerCinematicQueueItem item)
        {
            this.Terminal = this.Target.GetComponent<global::PrecursorTeleporterActivationTerminal>();
            this.Terminal.animator.SetBool("Open", true);
        }

        /**
         *
         * Animasyonu resetler.
         *
         
         *
         */
        public override IEnumerator OnResetAnimationsAsync(PlayerCinematicQueueItem item)
        {
            var result = new TaskResult<GameObject>();

            yield return base.OnResetAnimationsAsync(item);
            yield return CraftData.InstantiateFromPrefabAsync(TechType.PrecursorIonCrystal, result);
            
            this.InitializeIonCube(result.Get());

        }

        /**
         *
         * Terminal animasyonunu başlatır.
         *
         
         *
         */
        public void ActivatePrecursorTerminalCinematic()
        {
            this.Terminal.unlocked = true;

            Utils.PlayFMODAsset(this.Terminal.useSound, this.Terminal.transform);

            this.SetCinematic(this.Terminal.cinematicController);
            this.SetCinematicEndMode(this.ActivateTeleportEndMode);
            this.StartCinematicMode();
        }

        /**
         *
         * İyon küpünü hazırlar.
         *
         
         *
         */
        private void InitializeIonCube(GameObject gameObject)
        {
            if (gameObject.TryGetComponent<global::Pickupable>(out var pickupable))
            {
                pickupable.Initialize();

                if (this.Terminal)
                {
                    this.Terminal.unlocked = true;
                    this.Terminal.crystalObject = pickupable.gameObject;
                    this.Terminal.crystalObject.transform.SetParent(this.ZeroPlayer.RightHandItemTransform);
                    this.Terminal.crystalObject.transform.localPosition = Vector3.zero;
                    this.Terminal.crystalObject.transform.localRotation = Quaternion.identity;
                    this.Terminal.crystalObject.SetActive(true);

                    if (this.Terminal.crystalObject.TryGetComponent<Rigidbody>(out var rigidbody))
                    {
                        rigidbody.SetKinematic();
                    }
                }
            }
        }

        /**
         *
         * Cinematik bittiğinde tetiklenecek kancayı değiştirir.
         *
         
         *
         */
        private void ActivateTeleportEndMode()
        {
            if (this.Terminal)
            {
                if (this.Terminal.crystalObject)
                {
                    this.Terminal.crystalObject.transform.SetParent(null);
                    this.Terminal.crystalObject.Destroy();
                }

                this.Terminal.CloseDeck();

                if (this.Terminal.root)
                {
                    this.Terminal.root.BroadcastMessage("ToggleDoor", true, SendMessageOptions.RequireReceiver);
                }
                else
                {
                    this.Terminal.BroadcastMessage("ToggleDoor", true, SendMessageOptions.RequireReceiver);
                }
            }
        }
    }
}