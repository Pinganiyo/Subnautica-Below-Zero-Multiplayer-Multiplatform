namespace Subnautica.Events.EventArgs
{
    using System;

    public class BenchSitdownEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BenchSitdownEventArgs(string uniqueId, Bench.BenchSide side, TechType techType, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.Side      = side;
            this.TechType  = techType;
            this.IsAllowed = isAllowed;
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

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
