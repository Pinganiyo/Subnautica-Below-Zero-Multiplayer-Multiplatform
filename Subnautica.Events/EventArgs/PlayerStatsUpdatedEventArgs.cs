namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerStatsUpdatedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerStatsUpdatedEventArgs(float health, float food, float water)
        {
            this.Health = health;
            this.Food = food;
            this.Water = water;
        }

        /**
         *
         * Sağlık değeri
         *
         
         *
         */
        public float Health { get; }

        /**
         *
         * Animasyonun çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public float Food { get; }

        /**
         *
         * Su değeri
         *
         
         *
         */
        public float Water { get; }
    }
}
