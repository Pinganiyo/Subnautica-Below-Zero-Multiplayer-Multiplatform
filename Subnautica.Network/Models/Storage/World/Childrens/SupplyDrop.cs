namespace Subnautica.Network.Models.Storage.World.Childrens
{
    using MessagePack;

    using Subnautica.API.Extensions;
    using Subnautica.Network.Structures;

    using UnityEngine;

    [MessagePackObject]
    public class SupplyDrop
    {
        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(0)]
        public string UniqueId { get; set; } = null;

        /**
         *
         * FabricatorUniqueId Değeri
         *
         
         *
         */
        [Key(1)]
        public string FabricatorUniqueId { get; set; } = null;

        /**
         *
         * StorageUniqueId Değeri
         *
         
         *
         */
        [Key(2)]
        public string StorageUniqueId { get; set; } = null;

        /**
         *
         * Key Değeri
         *
         
         *
         */
        [Key(3)]
        public string Key { get; set; } = null;

        /**
         *
         * StartedTime Değeri
         *
         
         *
         */
        [Key(4)]
        public float StartedTime { get; set; } = 0f;

        /**
         *
         * ZoneId Değeri
         *
         
         *
         */
        [Key(5)]
        public sbyte ZoneId { get; set; } = -1;

        /**
         *
         * ZoneId Değeri
         *
         
         *
         */
        [Key(6)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * StorageContainer Değeri
         *
         
         *
         */
        [Key(7)]
        public Metadata.StorageContainer StorageContainer { get; set; }

        /**
         *
         * Sınf ayarlamalarını yapar.
         *
         
         *
         */
        public void SetConfiguration(float startedTime)
        {
            this.StartedTime = startedTime;
            this.ZoneId      = (sbyte)Random.Range(0, 3);
        }

        /**
         *
         * Sınf ayarlamalarını yapar.
         *
         
         *
         */
        public void SetKey(string key)
        {
            this.Key = key;
        }

        /**
         *
         * Sınf ayarlamalarını yapar.
         *
         
         *
         */
        public void Initialize()
        {
            this.FabricatorUniqueId = API.Features.Network.Identifier.GenerateUniqueId();
            this.StorageUniqueId    = API.Features.Network.Identifier.GenerateUniqueId();
            this.UniqueId           = API.Features.Network.Identifier.GenerateUniqueId();
            this.Rotation           = Quaternion.Euler(0.0f, Random.Range(0, 360), 0.0f).ToZeroQuaternion();
        }

        /**
         *
         * Tamamlanma durumu
         *
         
         *
         */
        public bool IsCompleted(float currentTime)
        {
            return this.StartedTime != 0 && currentTime > this.StartedTime + 32f;
        }
    }
}
