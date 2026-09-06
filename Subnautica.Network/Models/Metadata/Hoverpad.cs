namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Hoverpad : MetadataComponent
    {
        /**
         *
         * IsSpawning değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsSpawning { get; set; }

        /**
         *
         * FinishedTime değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public float FinishedTime { get; set; }

        /**
         *
         * IsDocked değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsDocked { get; set; }

        /**
         *
         * ItemId değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public string ItemId { get; set; }

        /**
         *
         * IsDocking değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsDocking { get; set; }

        /**
         *
         * IsUnDocking değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public bool IsUnDocking { get; set; }

        /**
         *
         * IsCustomizerOpening değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsCustomizerOpening { get; set; }

        /**
         *
         * ShowroomTriggerType değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public byte ShowroomTriggerType { get; set; }

        /**
         *
         * ShowroomPlayerCount değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public byte ShowroomPlayerCount { get; set; }

        /**
         *
         * HoverbikePosition değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public ZeroVector3 HoverbikePosition { get; set; }

        /**
         *
         * HoverbikeRotation değerini barındırır.
         *
         
         *
         */
        [Key(10)]
        public ZeroQuaternion HoverbikeRotation { get; set; }

        /**
         *
         * ColorCustomizer değerini barındırır.
         *
         
         *
         */
        [Key(11)]
        public ZeroColorCustomizer ColorCustomizer { get; set; }

        /**
         *
         * Hoverbike değerini barındırır.
         *
         
         *
         */
        [Key(12)]
        public Hoverbike Hoverbike { get; set; }

        /**
         *
         * Entity değerini barındırır.
         *
         
         *
         */
        [Key(13)]
        public WorldDynamicEntity Entity { get; set; }
    }
}
