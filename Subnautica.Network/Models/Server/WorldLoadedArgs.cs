namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class WorldLoadedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.WorldLoaded;

        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.Startup;

        /**
         *
         * IsSpawnPointRequest Değeri
         *
         
         *
         */
        [Key(5)]
        public bool IsSpawnPointRequest { get; set; }

        /**
         *
         * SpawnPointCount Değeri
         *
         
         *
         */
        [Key(6)]
        public int SpawnPointCount { get; set; }

        /**
         *
         * Resim İsimleri
         *
         
         *
         */
        [Key(7)]
        public List<string> Images { get; set; }
    }
}
