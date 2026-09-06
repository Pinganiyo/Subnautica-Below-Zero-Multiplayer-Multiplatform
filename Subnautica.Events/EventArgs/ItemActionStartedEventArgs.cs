namespace Subnautica.Events.EventArgs
{
    using System;

    public class ItemActionStartedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ItemActionStartedEventArgs(TechType techType, bool isFirstUseAnimationStarted)
        {
            this.TechType = techType;
            this.IsFirstUseAnimationStarted = isFirstUseAnimationStarted;
        }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * IsFirstUseAnimationStarted Değeri
         *
         
         *
         */
        public bool IsFirstUseAnimationStarted { get; private set; }
    }
}
