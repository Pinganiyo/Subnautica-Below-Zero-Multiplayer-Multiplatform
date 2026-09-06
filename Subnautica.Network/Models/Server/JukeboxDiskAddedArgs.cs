namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class JukeboxDiskAddedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.JukeboxDiskAdded;

        /**
         *
         * TrackFile Değeri
         *
         
         *
         */
        [Key(5)]
        public string TrackFile { get; set; }

        /**
         *
         * Notify Değeri
         *
         
         *
         */
        [Key(6)]
        public bool Notify { get; set; }
    }
}
