namespace Subnautica.Events.EventArgs
{
    using System;

    public class ConstructionRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructionRemovedEventArgs(TechType techType, string uniqueId, Int3? cell = null)
        {
            this.TechType = techType;
            this.UniqueId = uniqueId;
            this.Cell     = cell;
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
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * Cell değeri
         *
         
         *
         */
        public Int3? Cell { get; private set; }
    }
}
