namespace Subnautica.Events.EventArgs
{
    using System;

    public class SignDataChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SignDataChangedEventArgs(string uniqueId, TechType techType, string text, int scaleIndex, int colorIndex, bool[] elementsState, bool isBackgroundEnabled)
        {
            this.UniqueId            = uniqueId;
            this.TechType            = techType;
            this.Text                = text;
            this.ScaleIndex          = scaleIndex;
            this.ColorIndex          = colorIndex;
            this.ElementsState       = elementsState;
            this.IsBackgroundEnabled = isBackgroundEnabled;
        }

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        public string UniqueId { get; private set; }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Text Değeri
         *
         
         *
         */
        public string Text { get; private set; }

        /**
         *
         * ScaleIndex Değeri
         *
         
         *
         */
        public int ScaleIndex { get; private set; }

        /**
         *
         * ColorIndex Değeri
         *
         
         *
         */
        public int ColorIndex { get; private set; }

        /**
         *
         * ElementsState Değeri
         *
         
         *
         */
        public bool[] ElementsState { get; private set; }

        /**
         *
         * IsBackgroundEnabled Değeri
         *
         
         *
         */
        public bool IsBackgroundEnabled { get; private set; }
    }
}
