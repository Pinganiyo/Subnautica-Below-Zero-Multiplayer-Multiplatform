namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Shower : MetadataComponent
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
        public Shower()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public Shower(bool isActive)
        {
            this.IsActive = isActive;
        }
    }
}
