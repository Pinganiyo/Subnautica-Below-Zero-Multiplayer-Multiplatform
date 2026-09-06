namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class LaserCutter : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.LaserCutter;

        /**
         *
         * IsPlaying değeri
         *
         
         *
         */
        [Key(4)]
        public bool IsPlaying { get; set; }
    }
}