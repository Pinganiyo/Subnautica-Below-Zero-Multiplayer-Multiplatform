namespace Subnautica.Events.EventArgs
{
    using System;

    public class BedEnterInUseModeEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BedEnterInUseModeEventArgs(string uniqueId, Bed.BedSide side, TechType techType, bool isSeaTruckModule, bool isAllowed = true)
        {
            this.UniqueId         = uniqueId;
            this.Side             = side;
            this.TechType         = techType;
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
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

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
