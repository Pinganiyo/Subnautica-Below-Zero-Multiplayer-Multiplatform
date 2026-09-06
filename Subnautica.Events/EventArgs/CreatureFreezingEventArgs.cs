namespace Subnautica.Events.EventArgs
{
    using System;

    public class CreatureFreezingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CreatureFreezingEventArgs(string uniqueId, float lifeTime, string brinicleId = null, bool isAllowed = true)
        {
            this.UniqueId   = uniqueId;
            this.LifeTime   = lifeTime;
            this.BrinicleId = brinicleId;
            this.IsAllowed  = isAllowed;
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
         * LifeTime değeri
         *
         
         *
         */
        public float LifeTime { get; set; }

        /**
         *
         * InIce değeri
         *
         
         *
         */
        public string BrinicleId { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
