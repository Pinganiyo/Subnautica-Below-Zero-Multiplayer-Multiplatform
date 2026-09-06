namespace Subnautica.Events.EventArgs
{
    using System;

    public class CellLoadingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public CellLoadingEventArgs(EntityCell entityCell, Int3 batchId, Int3 cellId, int level)
        {
            this.EntityCell = entityCell;
            this.BatchId    = batchId;
            this.CellId     = cellId;
            this.Level      = level;
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

        /**
         *
         * Level Değeri
         *
         
         *
         */
        public int Level { get; private set; }
    }
}