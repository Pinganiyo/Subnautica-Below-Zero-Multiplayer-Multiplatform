namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;
    using Subnautica.API.Features;

    public class EntitySlotSpawningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EntitySlotSpawningEventArgs(int slotId, bool isAllowed = true)
        {
            this.SlotId    = slotId;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public int SlotId { get; set; }

        /**
         *
         * ClassId Değeri
         *
         
         *
         */
        public string ClassId { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
