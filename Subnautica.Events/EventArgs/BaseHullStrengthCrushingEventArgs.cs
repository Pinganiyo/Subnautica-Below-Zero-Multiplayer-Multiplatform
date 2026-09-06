namespace Subnautica.Events.EventArgs
{
    using System;

    public class BaseHullStrengthCrushingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseHullStrengthCrushingEventArgs(global::BaseHullStrength instance, bool isAllowed = true)
        {
            this.Instance  = instance;
            this.IsAllowed = isAllowed;
        }

        /**
         *
         * Instance Değerini barındırır.
         *
         
         *
         */
        public global::BaseHullStrength Instance { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
