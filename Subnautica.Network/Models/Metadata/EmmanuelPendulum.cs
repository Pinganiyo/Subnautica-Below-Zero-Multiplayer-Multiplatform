namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class EmmanuelPendulum : MetadataComponent
    {
        /**
         *
         * IsActive değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsActive { get; set; }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public EmmanuelPendulum()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public EmmanuelPendulum(bool isActive)
        {
            this.IsActive = isActive;
        }
    }
}
