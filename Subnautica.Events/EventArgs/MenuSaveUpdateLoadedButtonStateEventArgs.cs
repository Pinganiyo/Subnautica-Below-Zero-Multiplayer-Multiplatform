namespace Subnautica.Events.EventArgs
{
    using System;

    public class MenuSaveUpdateLoadedButtonStateEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public MenuSaveUpdateLoadedButtonStateEventArgs(MainMenuLoadButton button)
        {
            Button = button;
        }

        /**
         *
         * Button değeri
         *
         
         *
         */
        public MainMenuLoadButton Button { get; set; }
    }
}
