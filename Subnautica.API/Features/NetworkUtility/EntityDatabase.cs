namespace Subnautica.API.Features.NetworkUtility
{
    using System.Collections.Generic;

    using UWE;

    public class EntityDatabase
    {
        /**
         *
         * TechTypeInfos değerini barındırır.
         *
         
         *
         */
        private readonly Dictionary<TechType, WorldEntityInfo> TechTypeInfos = new Dictionary<TechType, WorldEntityInfo>();

        /**
         *
         * Teknoloji bilgisini önbelleğe ekler.
         *
         
         *
         */
        public void AddTechTypeInfo(TechType techType, WorldEntityInfo info)
        {
            this.TechTypeInfos[techType] = info;
        }

        /**
         *
         * Teknoloji bilgisini önbellekten döner.
         *
         
         *
         */
        public bool TryGetInfoByTechType(TechType techType, out WorldEntityInfo info)
        {
            return this.TechTypeInfos.TryGetValue(techType, out info);
        }

        /**
         *
         * Teknoloji bilgisini önbellekten döner.
         *
         
         *
         */
        public bool TryGetInfoByClassId(string classId, out WorldEntityInfo info)
        {
            return WorldEntityDatabase.TryGetInfo(classId, out info);
        }

        /**
         *
         * Verileri temizler.
         *
         
         *
         */
        public void Dispose()
        {

        }
    }
}
