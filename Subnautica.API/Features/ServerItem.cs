namespace Subnautica.API.Features
{
    using System;

    using Newtonsoft.Json;

    public class LocalServerItem
    {
        /**
         *
         * Sunucu Id
         *
         
         *
         */
        public string Id { get; set; }

        /**
         *
         * Sunucu Adı
         *
         
         *
         */
        public string Name { get; set; }

        /**
         *
         * Sunucu Ip Address
         *
         
         *
         */
        public string IpAddress { get; set; }

        /**
         *
         * Sunucu Port
         *
         
         *
         */
        public int Port { get; set; }
    }

    public class HostServerItem
    {
        /**
         *
         * Sunucu Id
         *
         
         *
         */
        [JsonIgnore]
        public string Id { get; set; }

        /**
         *
         * Sunucu Oyun Modu
         *
         
         *
         */
        public int GameMode { get; set; }

        /**
         *
         * Sunucu Oluşturulma Tarihi
         *
         
         *
         */
        public int CreationDate { get; set; }

        /**
         *
         * Son Oynama Tarihi
         *
         
         *
         */
        public int LastPlayedDate { get; set; }

        /**
         *
         * Oyun modu geçerli mi?
         *
         
         *
         */
        public bool IsValidGameMode()
        {
            foreach (int item in Enum.GetValues(typeof(GameModePresetId)))
            {
                if (item == this.GameMode)
                {
                    return true;
                }
            }

            return false;
        }

        /**
         *
         * Oyun modunu döner.
         *
         
         *
         */
        public GameModePresetId GetGameMode()
        {
            return (GameModePresetId)this.GameMode;
        }
    }
}
