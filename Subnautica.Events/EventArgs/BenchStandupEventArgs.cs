namespace Subnautica.Events.EventArgs
{
    using System;

    public class BenchStandupEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BenchStandupEventArgs(string uniqueId, Bench.BenchSide side, TechType techType)
        {
            this.UniqueId = uniqueId;
            this.Side     = side;
            this.TechType = techType;
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
        public Bench.BenchSide Side { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; }
    }
}
