namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Enums;
    using Subnautica.API.Features;

    public class BulkheadOpeningEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BulkheadOpeningEventArgs(string uniqueId, bool side, StoryCinematicType storyCinematicType, bool isAllowed = true)
        {
            this.UniqueId            = uniqueId;
            this.Side                = side;
            this.IsAllowed           = isAllowed;
            this.StoryCinematicType  = storyCinematicType;
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
         * StoryCinematicType değeri
         *
         
         *
         */
        public StoryCinematicType StoryCinematicType { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
