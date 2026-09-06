namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Features;

    public class FruitHarvestingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public FruitHarvestingEventArgs(PickPrefab pickPrefab, string uniqueId, TechType techType, byte maxSpawnableFruit, float spawnInterval, bool isAllowed = true)
        {
            this.PickPrefab          = pickPrefab;
            this.UniqueId            = uniqueId;
            this.TechType            = techType;
            this.MaxSpawnableFruit   = maxSpawnableFruit;
            this.SpawnInterval       = spawnInterval;
            this.IsAllowed           = isAllowed;
            this.IsStaticWorldEntity = Network.StaticEntity.IsStaticEntity(uniqueId);
        }

        /**
         *
         * PickPrefab değeri
         *
         
         *
         */
        public PickPrefab PickPrefab { get; set; }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * MaxSpawnableFruit değeri
         *
         
         *
         */
        public byte MaxSpawnableFruit { get; set; }

        /**
         *
         * SpawnInterval değeri
         *
         
         *
         */
        public float SpawnInterval { get; set; }

        /**
         *
         * IsStaticWorldEntity değeri
         *
         
         *
         */
        public bool IsStaticWorldEntity { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}