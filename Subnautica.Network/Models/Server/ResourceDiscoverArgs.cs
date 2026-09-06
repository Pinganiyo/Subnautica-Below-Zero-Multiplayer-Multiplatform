namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class ResourceDiscoverArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ResourceDiscover;

        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(5)]
        public TechType TechType { get; set; }

        /**
         *
         * MapRooms değeri
         *
         
         *
         */
        [Key(6)]
        public List<string> MapRooms { get; set; } = new List<string>();
    }
}