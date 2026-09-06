namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class EncyclopediaAddedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.EncyclopediaAdded;

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
         * Verbose Değeri
         *
         
         *
         */
        [Key(6)]
        public bool Verbose { get; set; }
    }
}
