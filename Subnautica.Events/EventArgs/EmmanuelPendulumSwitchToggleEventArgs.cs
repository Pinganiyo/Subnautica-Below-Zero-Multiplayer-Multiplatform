namespace Subnautica.Events.EventArgs
{
    using System;

    public class EmmanuelPendulumSwitchToggleEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public EmmanuelPendulumSwitchToggleEventArgs(string uniqueId, bool switchStatus, bool isAllowed = true)
        {
            this.UniqueId     = uniqueId;
            this.SwitchStatus = switchStatus;
            this.IsAllowed    = isAllowed;
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
         * SwitchStatus Değeri
         *
         
         *
         */
        public bool SwitchStatus { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
