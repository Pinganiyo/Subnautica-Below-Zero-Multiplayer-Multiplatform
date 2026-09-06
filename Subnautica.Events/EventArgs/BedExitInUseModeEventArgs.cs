namespace Subnautica.Events.EventArgs
{
    using System;

    public class BedExitInUseModeEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BedExitInUseModeEventArgs(string uniqueId, TechType techType, bool isSeaTruckModule)
        {
            this.UniqueId         = uniqueId;
            this.TechType         = techType;
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
    }
}
