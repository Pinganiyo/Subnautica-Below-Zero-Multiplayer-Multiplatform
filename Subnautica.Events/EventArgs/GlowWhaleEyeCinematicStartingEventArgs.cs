namespace Subnautica.Events.EventArgs
{
    using System;

    public class GlowWhaleEyeCinematicStartingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public GlowWhaleEyeCinematicStartingEventArgs(string uniqueId, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * CreatureId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
