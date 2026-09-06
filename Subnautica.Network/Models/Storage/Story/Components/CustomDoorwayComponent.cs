namespace Subnautica.Network.Models.Storage.Story.Components
{
    using MessagePack;

    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class CustomDoorwayComponent
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
         * Position Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Scale Değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public ZeroVector3 Scale { get; set; }

        /**
         *
         * IsActive Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsActive { get; set; } = true;

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public CustomDoorwayComponent()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public CustomDoorwayComponent(string uniqueId, ZeroVector3 position, ZeroQuaternion rotation, ZeroVector3 scale, bool isActive)
        {
            this.UniqueId = uniqueId;
            this.Position = position;
            this.Rotation = rotation;
            this.Scale    = scale;
            this.IsActive = isActive;
        }
    }
}