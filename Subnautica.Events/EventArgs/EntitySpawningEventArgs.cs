namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features;

    public class EntitySpawningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EntitySpawningEventArgs(string uniqueId, string classId, TechType techType, EntitySpawnLevel level, bool isPersistent, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.ClassId   = classId;
            this.TechType  = techType;
            this.Level     = level;
            this.IsAllowed = isAllowed;

            if (uniqueId.IsWorldStreamer())
            {
                this.SlotType = SlotType.WorldStreamer;
            }
            else if (isPersistent && !techType.IsCreature())
            {
                this.SlotType = SlotType.Static;

                Network.StaticEntity.AddStaticEntitySlot(this.UniqueId);
            }
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * ClassId Değeri
         *
         
         *
         */
        public string ClassId { get; private set; }

        /**
         *
         * Level Değeri
         *
         
         *
         */
        public EntitySpawnLevel Level { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * SlotType Değeri
         *
         
         *
         */
        public SlotType SlotType { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
