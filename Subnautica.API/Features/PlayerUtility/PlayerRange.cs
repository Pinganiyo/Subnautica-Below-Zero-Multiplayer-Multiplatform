namespace Subnautica.API.Features.PlayerUtility
{
    using System.Collections.Generic;
    using System.Linq;

    public class PlayerRange
    {
        /**
         *
         * En Yakın Oyuncu
         *
         
         *
         */
        public ZeroPlayer NearestPlayer { get; private set; }

        /**
         *
         * En Yakın Oyuncu Mesafesi
         *
         
         *
         */
        public float NearestPlayerDistance { get; private set; } = 99999f;

        /**
         *
         * En Uzak Oyuncu
         *
         
         *
         */
        public ZeroPlayer FarthestPlayer { get; private set; }

        /**
         *
         * En Uzak Oyuncu Mesafesi
         *
         
         *
         */
        public float FarthestPlayerDistance { get; private set; } = -99999f;

        /**
         *
         * Rastgele Oyuncu 
         *
         
         *
         */
        public ZeroPlayer RandomPlayer
        {
            get
            {
                if (this.randomPlayer == null)
                {
                    this.randomPlayer = ZeroPlayer.GetPlayerById(this.Players.ElementAt(Tools.GetRandomInt(0, this.Players.Count - 1)));
                }

                return this.randomPlayer;
            }
        }

        /**
         *
         * RandomPlayer değeri
         *
         
         *
         */
        private ZeroPlayer randomPlayer;

        /**
         *
         * Tüm oyuncular 
         *
         
         *
         */
        private List<byte> Players { get; set; } = new List<byte>();

        /**
         *
         * En yakındaki oyuncu günceller.
         *
         
         *
         */
        public void SetNearestPlayer(ZeroPlayer player, float distance)
        {
            this.NearestPlayer = player;
            this.NearestPlayerDistance = distance;
        }

        /**
         *
         * En uzaktaki oyuncu günceller.
         *
         
         *
         */
        public void SetFarthestPlayer(ZeroPlayer player, float distance)
        {
            this.FarthestPlayer = player;
            this.FarthestPlayerDistance = distance;
        }

        /**
         *
         * Oyuncu ekler.
         *
         
         *
         */
        public void AddPlayer(ZeroPlayer player, float distance)
        {
            this.Players.Add(player.PlayerId);
        }

        /**
         *
         * Oyuncu var mı?
         *
         
         *
         */
        public bool IsExistsPlayer()
        {
            return this.Players.Count > 0;
        }
    }
}
