namespace Subnautica.Events.EventArgs
{
    using System;

    public class BedIsCanSleepCheckingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BedIsCanSleepCheckingEventArgs(string uniqueId, Bed.BedSide side, bool isSeaTruckModule, bool isAllowed = true)
        {
            this.UniqueId         = uniqueId;
            this.Side             = side;
            this.IsAllowed        = isAllowed;
            this.IsSeaTruckModule = isSeaTruckModule;
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
         * Side Değerini barındırır.
         *
         
         *
         */
        public Bed.BedSide Side { get; set; }

        /**
         *
         * IsSeaTruckModule Değeri
         *
         
         *
         */
        public bool IsSeaTruckModule { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
