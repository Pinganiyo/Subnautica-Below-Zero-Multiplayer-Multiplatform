namespace Subnautica.Events.EventArgs
{
    using System;

    public class EnergyMixinSelectingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EnergyMixinSelectingEventArgs(string uniqueId, string batterySlotId, TechType batteryType, TechType techType, Pickupable item, bool isAdding = false, bool isChanging = false, bool isAllowed = true)
        {
            this.UniqueId      = uniqueId;
            this.BatterySlotId = batterySlotId;
            this.BatteryType   = batteryType;
            this.TechType      = techType;
            this.Item          = item;
            this.IsAdding      = isAdding;
            this.IsChanging    = isChanging;
            this.IsAllowed     = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * BatterySlotId Değerini barındırır.
         *
         
         *
         */
        public string BatterySlotId { get; set; }

        /**
         *
         * TechType Değerini barındırır.
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * BatteryType Değerini barındırır.
         *
         
         *
         */
        public TechType BatteryType { get; set; }

        /**
         *
         * Item Değerini barındırır.
         *
         
         *
         */
        public Pickupable Item { get; set; }

        /**
         *
         * IsAdding Değerini barındırır.
         *
         
         *
         */
        public bool IsAdding { get; set; }

        /**
         *
         * IsChanging Değerini barındırır.
         *
         
         *
         */
        public bool IsChanging { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
