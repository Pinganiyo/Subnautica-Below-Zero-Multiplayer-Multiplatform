namespace Subnautica.Events.EventArgs
{
    using System;

    public class HoverpadShowroomTriggeringEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public HoverpadShowroomTriggeringEventArgs(string uniqueId, bool isEnter, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.IsEnter   = isEnter;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * IsEnter değeri
         *
         
         *
         */
        public bool IsEnter { get; private set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}