namespace Subnautica.Events.EventArgs
{
    using System;

    public class UpgradeConsoleModuleRemovedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public UpgradeConsoleModuleRemovedEventArgs(string uniqueId, string slotId, string itemId, TechType moduleType)
        {
            this.UniqueId    = uniqueId;
            this.SlotId      = slotId;
            this.ItemId      = itemId;
            this.ModuleType  = moduleType;
        }

        /**
         *
         * UniqueId değeri
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
        public string SlotId { get; set; }

        /**
         *
         * ItemId değeri
         *
         
         *
         */
        public string ItemId { get; set; }

        /**
         *
         * ModuleType değeri
         *
         
         *
         */
        public TechType ModuleType { get; set; }
    }
}
