namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class JoiningServerArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.JoiningServer;

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
         * Oyuncu ID
         *
         
         *
         */
        [Key(5)]
        public string UserId { get; set; }

        /**
         *
         * Oyuncu Nicki
         *
         
         *
         */
        [Key(6)]
        public string UserName { get; set; }

        /**
         *
         * Yeniden Bağlantı Durumu
         *
         
         *
         */
        [Key(7)]
        public bool IsReconnect { get; set; } = false;
    }
}