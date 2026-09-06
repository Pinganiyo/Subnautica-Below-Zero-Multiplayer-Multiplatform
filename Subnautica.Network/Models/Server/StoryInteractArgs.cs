namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class StoryInteractArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.StoryInteract;

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * GoalKey Değeri
         *
         
         *
         */
        [Key(6)]
        public string GoalKey { get; set; }

        /**
         *
         * CinematicType Değeri
         *
         
         *
         */
        [Key(7)]
        public StoryCinematicType CinematicType { get; set; }
    }
}