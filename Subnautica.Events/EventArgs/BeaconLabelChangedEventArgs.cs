namespace Subnautica.Events.EventArgs
{
    using System;

    public class BeaconLabelChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BeaconLabelChangedEventArgs(string uniqueId, string text)
        {
            this.UniqueId = uniqueId;
            this.Text     = text;
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
         * Text Değerini barındırır.
         *
         
         *
         */
        public string Text { get; set; }
    }
}
