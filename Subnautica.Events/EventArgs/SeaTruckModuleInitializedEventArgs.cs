namespace Subnautica.Events.EventArgs
{
    using System;

    public class SeaTruckModuleInitializedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SeaTruckModuleInitializedEventArgs(global::SeaTruckSegment module, TechType techType)
        {
            this.Module   = module;
            this.TechType = techType;
        }

        /**
         *
         * Module Değerini barındırır.
         *
         
         *
         */
        public global::SeaTruckSegment Module { get; set; }

        /**
         *
         * TechType Değerini barındırır.
         *
         
         *
         */
        public TechType TechType { get; set; }
    }
}
