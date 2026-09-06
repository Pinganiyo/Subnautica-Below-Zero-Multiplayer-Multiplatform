namespace Subnautica.Events.EventArgs
{
    using System;

    public class BaseMapRoomResourceDiscoveringEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseMapRoomResourceDiscoveringEventArgs(TechType techType, bool isAllowed = true)
        {
            this.TechType  = techType;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
