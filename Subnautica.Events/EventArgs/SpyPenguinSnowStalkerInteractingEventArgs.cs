namespace Subnautica.Events.EventArgs
{
    using System;

    public class SpyPenguinSnowStalkerInteractingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SpyPenguinSnowStalkerInteractingEventArgs(string uniqueId, float spawnChance, bool isAllowed = true)
        {
            this.UniqueId    = uniqueId;
            this.SpawnChance = spawnChance;
            this.IsAllowed   = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * SpawnChance Değerini barındırır.
         *
         
         *
         */
        public float SpawnChance { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
