namespace Subnautica.Events.EventArgs
{
    using System;

    public class CrafterClosedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CrafterClosedEventArgs(string uniqueId, TechType fabricatorType)
        {
            this.UniqueId = uniqueId;
            this.FabricatorType = fabricatorType;
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
    }
}