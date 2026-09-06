namespace Subnautica.Network.Structures
{
    using MessagePack;

    [MessagePackObject]
    public class ZeroTransform
    {
        /**
         *
         * Forward
         *
         
         *
         */
        [Key(0)]
        public ZeroVector3 Forward;

        /**
         *
         * Position
         *
         
         *
         */
        [Key(1)]
        public ZeroVector3 Position;

        /**
         *
         * Rotation
         *
         
         *
         */
        [Key(2)]
        public ZeroQuaternion Rotation;

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroTransform()
        {
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroTransform(ZeroVector3 forward, ZeroVector3 position, ZeroQuaternion rotation)
        {
            this.Forward  = forward;
            this.Position = position;
            this.Rotation = rotation;
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroTransform(ZeroVector3 position, ZeroQuaternion rotation)
        {
            this.Position = position;
            this.Rotation = rotation;
        }

        /**
         *
         * Metin olarak bastırır.
         *
         
         *
         */
        public override string ToString()
        {
            return $"[ZeroTransform: {this.Forward}, {this.Position}, {this.Rotation}]";
        }
    }
}
