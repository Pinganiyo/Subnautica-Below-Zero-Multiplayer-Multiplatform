namespace Subnautica.Client.Multiplayer.Furnitures
{
    using System.Collections.Generic;
    using System.Linq;

    using Subnautica.API.Extensions;

    using Metadata = Subnautica.Network.Models.Metadata;

    public class Bed
    {
        /**
         *
         * Yatak verilerini barındırır.
         *
         
         *
         */
        private static HashSet<string> Beds { get; set; } = new HashSet<string>();

        /**
         *
         * Uyuyan toplam oyuncu sayısını döner.
         *
         
         *
         */
        public static int GetSleepingPlayerCount()
        {
            return Beds.Count;
        }

        /**
         *
         * Yatağı günceller.
         *
         
         *
         */
        public static bool UpdateBed(string playerId)
        {
            return Bed.Beds.Add(playerId);
        }

        /**
         *
         * Yatağı günceller.
         *
         
         *
         */
        public static bool IsSleeping(string playerId)
        {
            return Bed.Beds.Contains(playerId);
        }

        /**
         *
         * Eski yataklardaki oyuncuyu siler.
         *
         
         *
         */
        public static bool ClearBed(string playerId)
        {
            return Bed.Beds.Remove(playerId);
        }

        /**
         *
         * Tüm verileri temizler.
         *
         
         *
         */
        public static void Dispose()
        {
            Beds.Clear();
        }
    }
}