namespace Subnautica.Events.EventArgs
{
    using System;

    public class AlterraPdaPickedUpEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public AlterraPdaPickedUpEventArgs(string uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }
    }
}