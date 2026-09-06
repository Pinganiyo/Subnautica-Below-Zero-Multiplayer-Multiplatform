namespace Subnautica.Events.EventArgs
{
    using System;

    public class TechnologyFragmentAddedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public TechnologyFragmentAddedEventArgs(string uniqueId, TechType type, int unlocked, int totalFragment)
        {
            this.UniqueId      = uniqueId;
            this.TechType      = type;
            this.Unlocked      = unlocked;
            this.TotalFragment = totalFragment;
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
         * Unlocked Değeri
         *
         
         *
         */
        public int Unlocked { get; private set; }

        /**
         *
         * TotalFragment
         *
         
         *
         */
        public int TotalFragment { get; private set; }
    }
}
