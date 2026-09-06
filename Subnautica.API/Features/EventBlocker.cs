namespace Subnautica.API.Features
{
    using System;
    using System.Collections.Generic;
    
    using Subnautica.API.Enums;

    public class EventBlocker : IDisposable
    {
        /**
         *
         * Bloklu listeyi barındırır.
         *
         
         *
         */
        private static List<ProcessType> ProcessList { get; set; } = new List<ProcessType>();

        /**
         *
         * Bloklu listeyi barındırır.
         *
         
         *
         */
        private static List<TechType> TechList { get; set; } = new List<TechType>();

        /**
         *
         * İşlem Türü
         *
         
         *
         */
        private ProcessType ProcessType { get; set; } = ProcessType.None;

        /**
         *
         * Teknoloji Türü
         *
         
         *
         */
        private TechType TechType { get; set; } = TechType.None;

        /**
         *
         * Bloklu listeye veri ekler.
         *
         
         *
         */
        public static EventBlocker Create(ProcessType type)
        {
            return new EventBlocker(type);
        }

        /**
         *
         * Bloklu listeye veri ekler.
         *
         
         *
         */
        public static EventBlocker Create(TechType type)
        {
            return new EventBlocker(type);
        }

        /**
         *
         * Olayın bloklanıp bloklanmadığını kontrol eder.
         *
         
         *
         */
        public static bool IsEventBlocked(ProcessType type)
        {
            return ProcessList.Contains(type);
        }

        /**
         *
         * Olayın bloklanıp bloklanmadığını kontrol eder.
         *
         
         *
         */
        public static bool IsEventBlocked(TechType type)
        {
            return TechList.Contains(type);
        }

        /**
         *
         * ProcessType Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public EventBlocker(ProcessType type)
        {
            this.ProcessType = type;
            ProcessList.Add(type);
        }

        /**
         *
         * TechType Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public EventBlocker(TechType type)
        {
            this.TechType = type;
            TechList.Add(type);
        }

        /**
         *
         * Bloklu listeden kaldırma işlemi yapar.
         *
         
         *
         */
        public void Dispose()
        {
            if (this.ProcessType != ProcessType.None)
            {
                ProcessList.Remove(this.ProcessType);
            }

            if (this.TechType != TechType.None)
            {
                TechList.Remove(this.TechType);
            }
        }
    }
}
