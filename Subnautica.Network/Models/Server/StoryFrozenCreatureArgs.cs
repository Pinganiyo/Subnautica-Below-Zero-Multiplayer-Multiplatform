namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class StoryFrozenCreatureArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StoryFrozenCreature;

        /**
         *
         * CinematicType değeri
         *
         
         *
         */
        [Key(5)]
        public StoryCinematicType CinematicType { get; set; }

        /**
         *
         * InjectTime değeri
         *
         
         *
         */
        [Key(6)]
        public float InjectTime { get; set; }

        /**
         *
         * IsDenied değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsDenied { get; set; }
    }
}
