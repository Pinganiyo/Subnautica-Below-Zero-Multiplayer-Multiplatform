namespace Subnautica.Events.EventArgs
{
    using System;

    public class SeaTruckConnectingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SeaTruckConnectingEventArgs(string frontModuleId, string backModuleId, string firstModuleId, bool isConnect, bool isMoonpoolExpansion, bool isAllowed = true)
        {
            this.FrontModuleId = frontModuleId;
            this.BackModuleId  = backModuleId;
            this.FirstModuleId = firstModuleId;
            this.IsConnect     = isConnect;
            this.IsMoonpoolExpansion = isMoonpoolExpansion;
            this.IsAllowed     = isAllowed;
        }

        /**
         *
         * FrontModuleId Değerini barındırır.
         *
         
         *
         */
        public string FrontModuleId { get; set; }

        /**
         *
         * BackModuleId Değerini barındırır.
         *
         
         *
         */
        public string BackModuleId { get; set; }

        /**
         *
         * FirstModuleId Değerini barındırır.
         *
         
         *
         */
        public string FirstModuleId { get; set; }

        /**
         *
         * IsConnect Değerini barındırır.
         *
         
         *
         */
        public bool IsConnect { get; set; }

        /**
         *
         * IsMoonpoolExpansion Değerini barındırır.
         *
         
         *
         */
        public bool IsMoonpoolExpansion { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
