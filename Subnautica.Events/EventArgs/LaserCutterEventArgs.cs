namespace Subnautica.Events.EventArgs
{
    using System;

    public class LaserCutterEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public LaserCutterEventArgs(string uniqueId, float amount, float maxAmount, bool isAllowed = true)
        {
            this.UniqueId  = uniqueId;
            this.Amount    = amount;
            this.MaxAmount = maxAmount;
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
         * Amount Değerini barındırır.
         *
         
         *
         */
        public float Amount { get; set; }

        /**
         *
         * MaxAmount Değerini barındırır.
         *
         
         *
         */
        public float MaxAmount { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
