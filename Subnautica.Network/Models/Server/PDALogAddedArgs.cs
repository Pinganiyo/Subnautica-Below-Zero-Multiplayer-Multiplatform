namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class PDALogAddedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.PDALogAdded;

        /**
         *
         * Key Değeri
         *
         
         *
         */
        [Key(5)]
        public string Key { get; set; }

        /**
         *
         * Timestamp Değeri
         *
         
         *
         */
        [Key(6)]
        public float Timestamp { get; set; }
    }
}