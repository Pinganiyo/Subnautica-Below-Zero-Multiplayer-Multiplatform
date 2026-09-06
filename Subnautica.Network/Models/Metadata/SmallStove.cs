namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class SmallStove : MetadataComponent
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
        public SmallStove()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public SmallStove(bool isActive)
        {
            this.IsActive = isActive;
        }
    }
}
