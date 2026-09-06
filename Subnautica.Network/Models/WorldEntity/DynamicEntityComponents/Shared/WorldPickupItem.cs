namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features;
    using Subnautica.Network.Models.Metadata;

    [MessagePackObject]
    public class WorldPickupItem
    {

        /**
         *
         * Item Değeri
         *
         
         *
         */
        [Key(0)]
        public StorageItem Item { get; set; }

        /**
         *
         * Source Değeri
         *
         
         *
         */
        [Key(1)]
        public PickupSourceType Source { get; set; }

        /**
         *
         * NextRespawnTime Değeri
         *
         
         *
         */
        [Key(2)]
        public string CustomUniqueId { get; set; }

        /**
         *
         * NextRespawnTime Değeri
         *
         
         *
         */
        [Key(3)]
        public float NextRespawnTime { get; set; }

        /**
         *
         * Kaynağı değiştirir.
         *
         
         *
         */
        public void SetSource(PickupSourceType source)
        {
            this.Source = source;
        }

        /**
         *
         * Yeni özel id üretir.
         *
         
         *
         */
        public void GenerateCustomId()
        {
            this.CustomUniqueId = Network.Identifier.GenerateUniqueId();
        }

        /**
         *
         * Nesne id'sini döner.
         *
         
         *
         */
        public string GetItemId()
        {
            if (this.CustomUniqueId.IsNull())
            {
                return this.Item.ItemId;
            }

            return this.CustomUniqueId;
        }

        /**
         *
         * StorageItem nesnesini döner..
         *
         
         *
         */
        public StorageItem GetStorageItem()
        {
            return new StorageItem()
            {
                ItemId   = this.GetItemId(),
                Item     = this.Item.Item,
                TechType = this.Item.TechType,
                Size     = this.Item.Size,
            };
        }

        /**
         *
         * WorldPickupItem Oluşturur. (Client Side)
         *
         
         *
         */
        public static WorldPickupItem Create(Pickupable pickupable, PickupSourceType sourceType = PickupSourceType.Automatic, bool resetItem = false)
        {
            return WorldPickupItem.Create(StorageItem.Create(pickupable, resetItem), sourceType);
        }

        /**
         *
         * WorldPickupItem Oluşturur. (Client Side)
         *
         
         *
         */
        public static WorldPickupItem Create(string uniqueId, TechType techType, PickupSourceType sourceType = PickupSourceType.Automatic)
        {
            return WorldPickupItem.Create(StorageItem.Create(uniqueId, techType), sourceType);
        }

        /**
         *
         * WorldPickupItem Oluşturur. (Client/Server Side)
         *
         
         *
         */
        public static WorldPickupItem Create(StorageItem storageItem, PickupSourceType sourceType = PickupSourceType.Automatic)
        {
            var pickupItem = new WorldPickupItem();
            pickupItem.Item   = storageItem;
            pickupItem.Source = sourceType == PickupSourceType.Automatic ? GetPickupSourceType(pickupItem.Item.ItemId) : sourceType;

            return pickupItem;
        }

        /**
         *
         * Kaynağı döner.
         *
         
         *
         */
        private static PickupSourceType GetPickupSourceType(string uniqueId)
        {
            if (Network.StaticEntity.IsStaticEntity(uniqueId))
            {
                return PickupSourceType.Static;
            }

            if (Network.DynamicEntity.HasEntity(uniqueId))
            {
                return PickupSourceType.Dynamic;
            }

            if (uniqueId.IsWorldStreamer())
            {
                return PickupSourceType.EntitySlot;
            }

            if (Network.Session.IsCosmeticItemExists(uniqueId))
            {
                return PickupSourceType.Dynamic;
            }

            return PickupSourceType.None;
        }
    }
}