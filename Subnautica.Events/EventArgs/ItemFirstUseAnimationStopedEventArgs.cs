namespace Subnautica.Events.EventArgs
{
    using System;

    public class ItemFirstUseAnimationStopedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ItemFirstUseAnimationStopedEventArgs(TechType techType)
        {
            this.TechType = techType;
        }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }
    }
}
