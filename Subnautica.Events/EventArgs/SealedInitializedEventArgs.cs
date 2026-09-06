namespace Subnautica.Events.EventArgs
{
    using System;

    public class SealedInitializedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SealedInitializedEventArgs(string uniqueId, Sealed sealedObject)
        {
            this.UniqueId     = uniqueId;
            this.SealedObject = sealedObject;
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
         * SealedObject Değeri
         *
         
         *
         */
        public Sealed SealedObject { get; private set; }
    }
}
