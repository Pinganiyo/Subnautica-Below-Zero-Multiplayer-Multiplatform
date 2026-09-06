namespace Subnautica.Events.EventArgs
{
    using System;

    public class PowerSourceAddingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PowerSourceAddingEventArgs(string uniqueId, IPowerInterface powerSource)
        {
            this.UniqueId = uniqueId;
            this.PowerSource = powerSource;
        }

        /**
         *
         * ConstructionId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * SlotId değeri
         *
         
         *
         */
        public IPowerInterface PowerSource { get; set; }
    }
}
