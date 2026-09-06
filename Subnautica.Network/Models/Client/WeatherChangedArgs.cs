namespace Subnautica.Network.Models.Client
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class WeatherChangedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.WeatherChanged;

        /**
         *
         * ProfileId nesnesini barındırır.
         *
         
         *
         */
        [Key(5)]
        public string ProfileId { get; set; }

        /**
         *
         * ProfileId nesnesini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsProfile { get; set; }
    }
}