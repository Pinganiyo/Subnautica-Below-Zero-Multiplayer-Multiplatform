namespace Subnautica.Events.EventArgs
{
    using System;

    public class UseableDiveHatchClickingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public UseableDiveHatchClickingEventArgs(string uniqueId, bool isEnter, string playerViewAnimation, bool isMoonpoolExpansion, bool isAllowed = true)
        {
            this.UniqueId            = uniqueId;
            this.IsEnter             = isEnter;
            this.IsBulkHead          = playerViewAnimation.Contains("surfacebasedoor_");
            this.IsLifePod           = playerViewAnimation.Contains("droppod_");
            this.IsMoonpoolExpansion = isMoonpoolExpansion;
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
         * IsEnter değeri
         *
         
         *
         */
        public bool IsEnter { get; set; }

        /**
         *
         * IsBulkHead değeri
         *
         
         *
         */
        public bool IsBulkHead { get; set; }

        /**
         *
         * IsLifePod değeri
         *
         
         *
         */
        public bool IsLifePod { get; set; }

        /**
         *
         * IsMoonpoolExpansion değeri
         *
         
         *
         */
        public bool IsMoonpoolExpansion { get; set; }

        /**
         *
         * IsAllowed değeri
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}