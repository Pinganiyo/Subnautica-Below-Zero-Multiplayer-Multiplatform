namespace Subnautica.Events.EventArgs
{
    using System;

    public class ConstructorEngageToggleEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructorEngageToggleEventArgs(string uniqueId, bool isEngage, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.IsEngage  = isEngage;
            this.IsAllowed = isAllowed;
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
         * IsEngage Değeri
         *
         
         *
         */
        public bool IsEngage { get; private set; }

        /**
         *
         * IsAllowed Değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
