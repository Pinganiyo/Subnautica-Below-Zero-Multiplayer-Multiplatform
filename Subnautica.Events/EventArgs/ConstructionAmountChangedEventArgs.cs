namespace Subnautica.Events.EventArgs
{
    using System;
    public class ConstructionAmountChangedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public ConstructionAmountChangedEventArgs(TechType techType, float constructedAmount, bool isConstruct, string uniqueId)
        {
            this.TechType    = techType;
            this.UniqueId    = uniqueId;
            this.IsConstruct = isConstruct;
            this.Amount      = constructedAmount;
        }

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * Amount Değeri
         *
         
         *
         */
        public float Amount { get; private set; }

        /**
         *
         * IsConstruct Değeri
         *
         
         *
         */
        public bool IsConstruct { get; private set; }

        /**
         *
         * Kimlik
         *
         
         *
         */
        public string UniqueId { get; private set; }
    }
}
