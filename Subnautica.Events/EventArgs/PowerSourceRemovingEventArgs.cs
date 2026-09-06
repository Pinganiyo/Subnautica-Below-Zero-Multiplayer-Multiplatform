namespace Subnautica.Events.EventArgs
{
    using System;

    public class PowerSourceRemovingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PowerSourceRemovingEventArgs(string uniqueId, IPowerInterface powerSource)
        {
            this.UniqueId    = uniqueId;
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
