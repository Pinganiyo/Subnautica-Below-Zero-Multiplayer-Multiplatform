namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features;

    using UnityEngine;

    public class EntitySpawnedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EntitySpawnedEventArgs(string uniqueId, GameObject gameObject, string classId, TechType techType, EntitySpawnLevel level, bool isPersistent)
        {
            this.UniqueId   = uniqueId;
            this.GameObject = gameObject;
            this.ClassId    = classId;
            this.TechType   = techType;
            this.Level      = level;

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
         * GameObject Değeri
         *
         
         *
         */
        public GameObject GameObject { get; private set; }

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
        public SlotType SlotType { get; set; }
    }
}
