namespace Subnautica.Events.EventArgs
{
    using System;
    using Subnautica.API.Enums.Creatures;

    public class GlowWhaleSFXTriggeredEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public GlowWhaleSFXTriggeredEventArgs(string uniqueId, GlowWhaleSFXType sfxType)
        {
            this.UniqueId = uniqueId;
            this.SFXType  = sfxType;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * sfxType değeri
         *
         
         *
         */
        public GlowWhaleSFXType SFXType { get; set; }
    }
}
