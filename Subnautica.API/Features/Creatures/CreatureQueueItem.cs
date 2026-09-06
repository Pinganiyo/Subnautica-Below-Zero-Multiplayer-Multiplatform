namespace Subnautica.API.Features.Creatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Subnautica.API.Features.Helper;

    public class CreatureQueueItem
    {
        /**
         *
         * CreatureId değeri
         *
         
         *
         */
        public ushort CreatureId { get; set; }

        /**
         *
         * IsSpawn değeri
         *
         
         *
         */
        public bool IsSpawn { get; set; }

        /**
         *
         * IsProcess değeri
         *
         
         *
         */
        public bool IsProcess { get; set; }

        /**
         *
         * IsChangeOWS değeri
         *
         
         *
         */
        public bool IsChangeOWS { get; set; }

        /**
         *
         * IsDeath değeri
         *
         
         *
         */
        public bool IsDeath { get; set; }

        /**
         *
         * ItemQueueAction Değeri
         *
         
         *
         */
        public CreatureQueueAction Action { get; set; }
    }

    public class CreatureQueueAction
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
         * İşlem türünde işlem tamamlandığında tetiklenir.
         *
         
         *
         */
        public Action<MultiplayerCreature, CreatureQueueItem> OnProcessCompleted { get; set; }

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
            if (property == null)
            {
                return default(T);
            }

            return (T) property.GetValue<T>();
        }
    }
}