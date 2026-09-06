namespace Subnautica.Events.EventArgs
{
    using System;

    public class VehicleInteriorToggleEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public VehicleInteriorToggleEventArgs(string uniqueId, bool isEnter)
        {
            this.UniqueId  = uniqueId;
            this.IsEnter   = isEnter;
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
         * IsEnter Değeri
         *
         
         *
         */
        public bool IsEnter { get; private set; }
    }
}
