namespace Subnautica.API.Features.Helper
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Subnautica.Network.Structures;

    using UnityEngine;

    public class ItemQueueProcess
    {
        /**
         *
         * Yumurtlama olup/olmadığı
         *
         
         *
         */
        public bool IsSpawning { get; set; } = false;

        /**
         *
         * İşlem olup/olmadığı
         *
         
         *
         */
        public bool IsProcess { get; set; } = false;

        /**
         *
         * Nesne Türü
         *
         
         *
         */
        public TechType TechType { get; set; } = TechType.None;

        /**
         *
         * ItemId Değeri
         *
         
         *
         */
        public string ItemId { get; set; }

        /**
         *
         * Item Değeri
         *
         
         *
         */
        public byte[] Item { get; set; }

        /**
         *
         * Container Değeri
         *
         
         *
         */
        public ItemsContainer Container { get; set; }

        /**
         *
         * Transform Değeri
         *
         
         *
         */
        public ZeroTransform Transform { get; set; }

        /**
         *
         * SlotId Değeri
         *
         
         *
         */
        public string SlotId { get; set; }

        /**
         *
         * Equipment Değeri
         *
         
         *
         */
        public Equipment Equipment { get; set; }

        /**
         *
         * Pickupable Değeri
         *
         
         *
         */
        public Pickupable Pickupable { get; set; }

        /**
         *
         * ItemQueueAction Değeri
         *
         
         *
         */
        public ItemQueueAction Action { get; set; } = new ItemQueueAction();

        /**
         *
         * Tüm veriyi temizler.
         *
         
         *
         */
        public void Dipose()
        {
            this.IsSpawning = false;
            this.IsProcess  = false;
            this.TechType   = TechType.None;
            this.Item       = null;
            this.Container  = null;
            this.Equipment  = null;
            this.Pickupable = null;
        }
    }

    public class ItemQueueAction
    {
        /**
         *
         * Özellikleri barındırır.
         *
         
         *
         */
       private List<GenericProperty> Properties = new List<GenericProperty>();

        /**
         *
         * Nesne doğarken tetiklenir.
         *
         
         *
         */
        public Func<ItemQueueProcess, bool> OnEntitySpawning { get; set; }

        /**
         *
         * Nesne doğduktan sonra tetiklenir.
         *
         
         *
         */
        public Action<ItemQueueProcess, Pickupable, GameObject> OnEntitySpawned { get; set; }

        /**
         *
         * İşlem türünde işlem tamamlandığında tetiklenir.
         *
         
         *
         */
        public Action<ItemQueueProcess> OnProcessCompleted { get; set; }

        /**
         *
         * İşlem türünde asenkron işlem tamamlandığında tetiklenir.
         *
         
         *
         */
        public Func<ItemQueueProcess, IEnumerator> OnProcessCompletedAsync { get; set; }

        /**
         *
         * Nesne yok edildikten sonra tetiklenir.
         *
         
         *
         */
        public Action<ItemQueueProcess> OnEntityRemoved { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ItemQueueAction(Func<ItemQueueProcess, bool> entitySpawning)
        {
            this.OnEntitySpawning = entitySpawning;
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ItemQueueAction(Action<ItemQueueProcess, Pickupable, GameObject> entitySpawned = null)
        {
            this.OnEntitySpawned = entitySpawned;
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ItemQueueAction(Func<ItemQueueProcess, bool> entitySpawning, Action<ItemQueueProcess, Pickupable, GameObject> entitySpawned)
        {
            this.OnEntitySpawning = entitySpawning;
            this.OnEntitySpawned  = entitySpawned;
        }

        /**
         *
         * Özellik kaydı yapar.
         *
         
         *
         */
        public void RegisterProperty(string key, object value)
        {
            this.Properties.Add(new GenericProperty(key, value));
        }

        /**
         *
         * Özellik kaydı yapar.
         *
         
         *
         */
        public T GetProperty<T>(string key)
        {
            var property = this.Properties.Where(q => q.Key == key).FirstOrDefault();
            if (property == null || property.Value == null)
            {
                return default(T);
            }

            return (T) property.Value;
        }
    }
}
