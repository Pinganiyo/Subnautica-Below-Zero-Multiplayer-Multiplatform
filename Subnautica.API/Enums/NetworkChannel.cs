namespace Subnautica.API.Enums
{
    public enum NetworkChannel : byte
    {   
        /**
         *
         * Varsayılan Kanal
         *
         
         *
         */
        Default,

        /**
         *
         * İnşaat Kanalı
         *
         
         *
         */
        Construction,

        /**
         *
         * Başlangıç Kanalı
         *
         
         *
         */
        Startup,

        /**
         *
         * Başlangıç Kanalı
         *
         
         *
         */
        StartupWorldLoaded,

        /**
         *
         * Enerji İletim Kanalı
         *
         
         *
         */
        EnergyTransmission,

        /**
         *
         * Oyuncu Animasyon İletim Kanalı
         *
         
         *
         */
        PlayerAnimation,

        /**
         *
         * Hareket Kanalları
         *
         
         *
         */
        PlayerMovement,
        VehicleMovement,
        EntityMovement,
        FishMovement,
    }
}