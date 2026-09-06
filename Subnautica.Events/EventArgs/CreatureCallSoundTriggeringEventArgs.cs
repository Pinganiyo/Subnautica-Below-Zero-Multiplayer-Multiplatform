namespace Subnautica.Events.EventArgs
{
    using System;

    public class CreatureCallSoundTriggeringEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureCallSoundTriggeringEventArgs(string uniqueId, byte callId, string animation = null, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.CallId    = callId;
            this.Animation = animation;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * Yaratık benzersiz ID değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * CallId değeri
         *
         
         *
         */
        public byte CallId { get; set; }

        /**
         *
         * Animation değeri
         *
         
         *
         */
        public string Animation { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
