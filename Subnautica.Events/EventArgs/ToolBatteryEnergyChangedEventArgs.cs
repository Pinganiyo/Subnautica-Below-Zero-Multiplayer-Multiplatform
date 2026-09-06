namespace Subnautica.Events.EventArgs
{
    using System;

    public class ToolBatteryEnergyChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ToolBatteryEnergyChangedEventArgs(string uniqueId, global::Pickupable item)
        {
            this.UniqueId = uniqueId;
            this.Item     = item;
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
         * Item Değeri
         *
         
         *
         */
        public global::Pickupable Item { get; private set; }
    }
}