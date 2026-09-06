namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Features;

    public class EnergyMixinClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EnergyMixinClickingEventArgs(string uniqueId, string batterySlotId, TechType techType, bool isAllowed = true)
        {
            this.UniqueId      = uniqueId;
            this.BatterySlotId = batterySlotId.Replace(ZeroGame.GetVehicleBatteryLabelUniqueId(null, true), "");
            this.TechType      = techType;
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
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
