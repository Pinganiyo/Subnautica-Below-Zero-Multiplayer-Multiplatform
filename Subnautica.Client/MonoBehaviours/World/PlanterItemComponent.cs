namespace Subnautica.Client.MonoBehaviours.World
{
    using UnityEngine;

    public class PlanterItemComponent : MonoBehaviour
    {
        /**
         *
         * Canı barındırır.
         *
         
         *
         */
        public float Health { get; private set; } = -1f;

        /**
         *
         * TimeNextFruit barındırır.
         *
         
         *
         */
        public float TimeNextFruit { get; private set; } = 0f;

        /**
         *
         * ActiveFruitCount barındırır.
         *
         
         *
         */
        public byte ActiveFruitCount { get; private set; } = 0;

        /**
         *
         * Başlangıç zamanını barındırır.
         *
         
         *
         */
        public float TimeStartGrowth { get; private set; } = 0f;

        /**
         *
         * Canı değiştirir.
         *
         
         *
         */
        public void SetHealth(float health)
        {
            this.Health = health;

            var grownPlant = this.GetComponent<Plantable>().linkedGrownPlant;
            if (grownPlant)
            {
                grownPlant.GetComponent<global::LiveMixin>().health = health;
            }
        }

        /**
         *
         * Süreyi değiştirir.
         *
         
         *
         */
        public void SetTimeNextFruit(float timeNextFruit)
        {
            this.TimeNextFruit = timeNextFruit;
        }

        /**
         *
         * ActiveFruitCount değerini değiştirir.
         *
         
         *
         */
        public void SetActiveFruitCount(byte activeFruitCount)
        {
            this.ActiveFruitCount = activeFruitCount;
        }

        /**
         *
         * Başlangıç zamanını değiştirir.
         *
         
         *
         */
        public void SetStartingTime(float time)
        {
            this.TimeStartGrowth = time;
        }
    }
}
