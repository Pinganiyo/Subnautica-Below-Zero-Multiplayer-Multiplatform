namespace Subnautica.Events.EventArgs
{
    using System;

    public class DeconstructionBeginEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public DeconstructionBeginEventArgs(string uniqueId, global::BaseDeconstructable baseDeconstructable, TechType techType, bool isAllowed = true)
        {
            this.UniqueId            = uniqueId;
            this.BaseDeconstructable = baseDeconstructable;
            this.TechType            = techType;
            this.IsAllowed           = isAllowed;
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
         * BaseDeconstructable
         *
         
         *
         */
        public global::BaseDeconstructable BaseDeconstructable { get; private set; }

        /**
         *
         * TechType
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
