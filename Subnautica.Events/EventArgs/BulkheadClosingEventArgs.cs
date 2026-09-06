namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Features;

    public class BulkheadClosingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BulkheadClosingEventArgs(string uniqueId, bool side, bool isAllowed = true)
        {
            this.UniqueId            = uniqueId;
            this.Side                = side;
            this.IsAllowed           = isAllowed;
            this.IsStaticWorldEntity = Network.StaticEntity.IsStaticEntity(uniqueId);
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
         * Side Değeri
         *
         
         *
         */
        public bool Side { get; set; }

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
