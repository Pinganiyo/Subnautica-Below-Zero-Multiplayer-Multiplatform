namespace Subnautica.Events.EventArgs
{
    using System;

    using Subnautica.API.Features;

    public class JukeboxUsedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public JukeboxUsedEventArgs(string uniqueId, CustomProperty data, bool isSeaTruckModule)
        {
            this.UniqueId         = uniqueId;
            this.Data             = data;
            this.IsSeaTruckModule = isSeaTruckModule;
        }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * Data Değerini barındırır.
         *
         
         *
         */
        public CustomProperty Data { get; private set; }

        /**
         *
         * IsSeaTruckModule Değerini barındırır.
         *
         
         *
         */
        public bool IsSeaTruckModule { get; private set; }
    }
}
