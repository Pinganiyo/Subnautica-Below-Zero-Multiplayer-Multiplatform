namespace Subnautica.Events.EventArgs
{
    using System;

    public class FurnitureDeconstructionBeginEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public FurnitureDeconstructionBeginEventArgs(string uniqueId, TechType techType, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.TechType  = techType;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
