namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Knife : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.Knife;

        /**
         *
         * VFXEventType Değeri
         *
         
         *
         */
        [Key(4)]
        public VFXEventTypes VFXEventType { get; set; }

        /**
         *
         * TargetPosition Değeri
         *
         
         *
         */
        [Key(5)]
        public ZeroVector3 TargetPosition { get; set; }

        /**
         *
         * Orientation Değeri
         *
         
         *
         */
        [Key(6)]
        public ZeroVector3 Orientation { get; set; }

        /**
         *
         * SurfaceType Değeri
         *
         
         *
         */
        [Key(7)]
        public VFXSurfaceTypes SurfaceType { get; set; }

        /**
         *
         * SoundSurfaceType Değeri
         *
         
         *
         */
        [Key(8)]
        public VFXSurfaceTypes SoundSurfaceType { get; set; }

        /**
         *
         * IsUnderwater Değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsUnderwater { get; set; }
    }
}