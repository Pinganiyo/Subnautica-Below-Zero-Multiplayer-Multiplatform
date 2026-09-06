namespace Subnautica.Network.Models.WorldEntity
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class BulkheadDoor : NetworkWorldEntityComponent
    {
        /**
         *
         * ProcessType değeri
         *
         
         *
         */
        [Key(2)]
        public override EntityProcessType ProcessType { get; set; } = EntityProcessType.BulkheadDoor;

        /**
         *
         * Side değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool Side { get; set; } = false;

        /**
         *
         * IsOpened değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public bool IsOpened { get; set; } = false;

        /**
         *
         * StoryCinematicType değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public StoryCinematicType StoryCinematicType { get; set; } = StoryCinematicType.None;
    }
}