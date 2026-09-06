namespace Subnautica.Events.EventArgs
{
    using System;

    public class ElevatorInitializedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ElevatorInitializedEventArgs(Rocket rocket)
        {
            this.Instance = rocket;
        }

        /**
         *
         * Instance Değerini barındırır.
         *
         
         *
         */
        public Rocket Instance { get; set; }
    }
}