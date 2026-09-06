namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class AromatherapyLamp : MetadataComponent
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
        public AromatherapyLamp()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public AromatherapyLamp(bool isActive)
        {
            this.IsActive = isActive;
        }
    }
}
