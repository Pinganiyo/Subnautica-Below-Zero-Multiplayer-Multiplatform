namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Bench : MetadataComponent
    {
        /**
         *
         * Side değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public global::Bench.BenchSide Side { get; set; }

        /**
         *
         * Oturma/Kalkma Durumu
         *
         
         *
         */
        [Key(1)]
        public bool IsSitdown { get; set; }

        /**
         *
         * Oturma/Kalkma Durumu
         *
         
         *
         */
        [Key(2)]
        public string PlayerId { get; set; }

        /**
         *
         * Oyuncu Id
         *
         
         *
         */
        [Key(3)]
        public byte PlayerId_v2 { get; set; }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public Bench()
        {

        }

        /**
         *
         * Sınıf ayarlamarlarını yapar
         *
         
         *
         */
        public Bench(global::Bench.BenchSide side, bool isSitdown)
        {
            this.Side      = side;
            this.IsSitdown = isSitdown;
        }

        /**
         *
         * Oyuncuya koltuğa bağlar.
         *
         
         *
         */
        public void Sitdown(byte playerId)
        {
            this.IsSitdown   = true;
            this.PlayerId    = null;
            this.PlayerId_v2 = playerId;
        }

        /**
         *
         * Oyuncuya koltuktan kaldırır.
         *
         
         *
         */
        public void Standup()
        {
            this.IsSitdown   = false;
            this.PlayerId_v2 = 0;
            this.PlayerId    = null;
        }
    }
}