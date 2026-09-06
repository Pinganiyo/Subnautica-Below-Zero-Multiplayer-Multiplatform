namespace Subnautica.Events.EventArgs
{
    using System;

    public class ScannerCompletedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ScannerCompletedEventArgs(TechType techType)
        {
            this.TechType = techType;
        }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; }
    }
}
