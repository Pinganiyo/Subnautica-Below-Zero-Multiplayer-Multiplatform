namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared
{
    using MessagePack;

    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class OxygenPipeItem
    {
        /**
         *
         * UniqueId Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public string UniqueId { get; set; }

        /**
         *
         * ParentId Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public string ParentId { get; set; }

        /**
         *
         * Position Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroVector3 Position { get; set; }
    }
}
