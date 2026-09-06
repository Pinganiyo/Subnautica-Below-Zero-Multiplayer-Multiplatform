namespace Subnautica.Events.EventArgs
{
    using System;

    public class QuickSlotActiveChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public QuickSlotActiveChangedEventArgs(int slotId)
        {
            this.SlotId = slotId;
        }

        /**
         *
         * SlotId değeri
         *
         
         *
         */
        public int SlotId { get; private set; }
    }
}
