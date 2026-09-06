namespace Subnautica.Network.Models.Storage.Player
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class PlayerItem
    {
        /**
         *
         * Oyuncu Benzersiz Id Kimliği
         *
         
         *
         */
        [Key(0)]
        public string UniqueId { get; set; }

        /**
         *
         * Oyuncu Id Kimliği
         *
         
         *
         */
        [Key(1)]
        public byte PlayerId { get; set; }

        /**
         *
         * Oyuncu Adı
         *
         
         *
         */
        [Key(2)]
        public string PlayerName { get; set; }

        /**
         *
         * Nesne Açısı
         *
         
         *
         */
        [Key(3)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Nesne Pozisyonu
         *
         
         *
         */
        [Key(4)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * SubrootId Değeri
         *
         
         *
         */
        [Key(5)]
        public string SubrootId { get; set; }

        /**
         *
         * InteriorId Değeri
         *
         
         *
         */
        [Key(6)]
        public string InteriorId { get; set; }
    }
}
