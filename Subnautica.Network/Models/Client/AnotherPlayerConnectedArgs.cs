namespace Subnautica.Network.Models.Client
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class AnotherPlayerConnectedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.AnotherPlayerConnected;

        /**
         *
         * Benzersiz Oyuncu Id
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * Benzersiz Oyuncu Id
         *
         
         *
         */
        [Key(6)]
        public byte PlayerId { get; set; }

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        [Key(7)]
        public string SubrootId { get; set; }

        /**
         *
         * InteriorId Değeri
         *
         
         *
         */
        [Key(8)]
        public string InteriorId { get; set; }

        /**
         *
         * Oyuncu Adı
         *
         
         *
         */
        [Key(9)]
        public string PlayerName { get; set; }

        /**
         *
         * Oyuncu Konumu
         *
         
         *
         */
        [Key(10)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Oyuncu Açısı
         *
         
         *
         */
        [Key(11)]
        public ZeroQuaternion Rotation { get; set; }
    }
}