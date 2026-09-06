namespace Subnautica.Client.MonoBehaviours.Entity
{
    using Subnautica.API.Features;
    using Subnautica.Client.MonoBehaviours.Entity.Components;

    using UnityEngine;

    public class MultiplayerEntityTracker : MonoBehaviour
    {
        /**
         *
         * Enterpolasyon sınıfını barındırır.
         *
         
         *
         */
        public EntityInterpolate Interpolate { get; set; } = new EntityInterpolate();

        /**
         *
         * Konum sınıfını barındırır.
         *
         
         *
         */
        public EntityPosition Position { get; set; } = new EntityPosition();

        /**
         *
         * Görünürlük sınıfını barındırır.
         *
         
         *
         */
        public EntityVisibility Visibility { get; set; } = new EntityVisibility();

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public void Update()
        {
            if (World.IsLoaded)
            {
                this.Visibility.Update();
                this.Position.Update();
                this.Interpolate.Update();
            }
        }
    }
}