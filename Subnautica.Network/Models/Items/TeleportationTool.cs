namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class TeleportationTool : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.TeleportationTool;

        /**
         *
         * TeleporterId Değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public string TeleporterId { get; set; }
    }
}