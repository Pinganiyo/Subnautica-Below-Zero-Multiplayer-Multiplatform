namespace Subnautica.Client.MonoBehaviours.World
{
    using UnityEngine;

    using Subnautica.API.Features;

    public class MultiplayerPipeSurfaceFloater : MonoBehaviour
    {
        /**
         *
         * Tamamlanma durumu.
         *
         
         *
         */
        private bool IsFinished { get; set; } = false;

        /**
         *
         * Zamanlayıcıyı barındırır.
         *
         
         *
         */
        private StopwatchItem Timing { get; set; } = new StopwatchItem(2000f);

        /**
         *
         * Her sabit karede tetiklenir.
         *
         
         *
         */
        public void FixedUpdate()
        {
            if (!this.IsFinished && this.Timing.IsFinished())
            {
                this.UpdateOxygenPipes();
            }
        }

        /**
         *
         * Oksijen borularını günceller.
         *
         
         *
         */
        private void UpdateOxygenPipes()
        {
            this.IsFinished = true;

            if (this.TryGetComponent<PipeSurfaceFloater>(out var floater))
            {
                foreach (var uniqueId in floater.children)
                {
                    var oxygenPipe = Network.Identifier.GetComponentByGameObject<OxygenPipe>(uniqueId);
                    if (oxygenPipe)
                    {
                        oxygenPipe.parentPosition = this.transform.position;
                        oxygenPipe.UpdatePipe();
                    }
                }
            }
        }

        /**
         *
         * Aktif olduğunda tetiklenir.
         *
         
         *
         */
        public void OnEnable()
        {
            this.IsFinished = false;

            this.Timing.Restart();
        }
    }
}
