namespace Subnautica.Events.EventArgs
{
    using System;

    public class CellUnLoadingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CellUnLoadingEventArgs(EntityCell entityCell, Int3 batchId, Int3 cellId)
        {
            this.EntityCell = entityCell;
            this.BatchId    = batchId;
            this.CellId     = cellId;
        }

        /**
         *
         * EntityCell Değeri
         *
         
         *
         */
        public EntityCell EntityCell { get; private set; }

        /**
         *
         * BatchId Değeri
         *
         
         *
         */
        public Int3 BatchId { get; private set; }

        /**
         *
         * CellId Değeri
         *
         
         *
         */
        public Int3 CellId { get; private set; }
    }
}
