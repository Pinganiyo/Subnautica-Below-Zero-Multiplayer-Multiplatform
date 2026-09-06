namespace Subnautica.API.Features
{
    using Subnautica.API.Enums;

    public abstract class SubnauticaPlugin
    {
        /**
         *
         * Eklenti Adı
         *
         
         *
         */
        public virtual string Name { get; }

        /**
         *
         * Eklenti önceliği
         *
         
         *
         */
        public virtual SubnauticaPluginPriority Priority { get; set; } = SubnauticaPluginPriority.Medium;

        /**
         *
         * Sınıf ayarlarını yapar.
         *
         
         *
         */
        public SubnauticaPlugin()
        {
        }

        /**
         *
         * Eklenti aktif edildiğinde tetiklenir.
         *
         
         *
         */
        public virtual void OnEnabled()
        {
        }

        /**
         *
         * Eklenti pasif edildiğinde tetiklenir.
         *
         
         *
         */
        public virtual void OnDisabled()
        {
        }
    }
}
