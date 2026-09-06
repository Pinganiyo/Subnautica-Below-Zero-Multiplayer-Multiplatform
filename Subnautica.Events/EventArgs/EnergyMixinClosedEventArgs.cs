namespace Subnautica.Events.EventArgs
{
    using System;

    public class EnergyMixinClosedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EnergyMixinClosedEventArgs(string uniqueId, string batterySlotId, TechType techType)
        {
            this.UniqueId      = uniqueId;
            this.BatterySlotId = batterySlotId;
            this.TechType      = techType;
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
    }
}
