namespace Subnautica.Events.EventArgs
{
    using System;

    public class SnowmanDestroyingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SnowmanDestroyingEventArgs(string uniqueId, bool isStaticWorldEntity, bool isAllowed = true)
        {
            this.UniqueId            = uniqueId;
            this.IsStaticWorldEntity = isStaticWorldEntity;
            this.IsAllowed           = isAllowed;
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
         * IsStaticWorldEntity değeri
         *
         
         *
         */
        public bool IsStaticWorldEntity { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
