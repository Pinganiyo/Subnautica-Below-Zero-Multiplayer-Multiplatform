namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BreakableResourceBreakingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BreakableResourceBreakingEventArgs(string uniqueId, TechType techType, Vector3 position, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.TechType  = techType;
            this.Position  = position;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * Position Değerini barındırır.
         *
         
         *
         */
        public Vector3 Position { get; set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
