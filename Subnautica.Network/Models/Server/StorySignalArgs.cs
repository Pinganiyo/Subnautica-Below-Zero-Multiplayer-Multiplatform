namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.Story.StoryGoals;
    using Subnautica.Network.Models.Storage.World.Childrens;

    [MessagePackObject]
    public class StorySignalArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StorySignal;

        /**
         *
         * SignalType değeri
         *
         
         *
         */
        [Key(5)]
        public ZeroStorySignal Signal { get; set; }

        /**
         *
         * Beacon değeri
         *
         
         *
         */
        [Key(6)]
        public WorldDynamicEntity Beacon { get; set; }
    }
}