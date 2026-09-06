namespace Subnautica.API.Enums
{
    public enum CreatureSpawnLevel : byte
    {
        /**
         *
         * Varsayılan (PrefabDatabase.TryGetPrefabFilename)
         *
         
         *
         */
        Default,

        /**
         *
         * Sahne (PrefabDatabase.GetPrefabAsync)
         *
         
         *
         */
        Scene,

        /**
         *
         * Özel (CreatureData.OnCustomCreatureSpawn)
         *
         
         *
         */
        Custom,

        /**
         *
         * Özel - ASYNC (CreatureData.OnCustomCreatureSpawnAsync)
         *
         
         *
         */
        CustomAsync
    }
}
