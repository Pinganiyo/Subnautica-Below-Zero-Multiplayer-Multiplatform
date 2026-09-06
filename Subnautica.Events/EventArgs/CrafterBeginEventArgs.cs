namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrafterBeginEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrafterBeginEventArgs(string uniqueId, TechType fabricatorType, TechType techType, float duration, bool isAllowed = true)
        {
            this.UniqueId = uniqueId;
            this.FabricatorType = fabricatorType;
            this.TechType = techType;
            this.Duration = duration;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * FabricatorType Değeri
         *
         
         *
         */
        public TechType FabricatorType { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Duration Değeri
         *
         
         *
         */
        public float Duration { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
