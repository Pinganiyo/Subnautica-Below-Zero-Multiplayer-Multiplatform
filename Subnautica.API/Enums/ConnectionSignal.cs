namespace Subnautica.API.Enums
{
    public enum ConnectionSignal : byte
    {
        /**
         *
         * Bilinmiyor
         *
         
         *
         */
        Unknown,

        /**
         *
         * Oyuncu bağlandı
         *
         
         *
         */
        Connected,

        /**
         *
         * Oyuncu bağlantı kesildi
         *
         
         *
         */
        Disconnected,

        /**
         *
         * Oyuncu bağlantısı reddedildi
         *
         
         *
         */
        Rejected,

        /**
         *
         * Sunucu versiyon uyuşmazlığı
         *
         
         *
         */
        VersionMismatch,

        /**
         *
         * Sunucu dolu
         *
         
         *
         */
        ServerFull,
    }
}
