namespace Subnautica.API.Enums
{
    public enum BuildingProgressType : byte
    {
        /**
         *
         * Varsayılan
         *
         
         *
         */
        None,

        /**
         *
         * Oluşturuluyor
         *
         
         *
         */
        Initializing,

        /**
         *
         * Hayalet Model Hareket Ediyor
         *
         
         *
         */
        GhostModelMoving,

        /**
         *
         * İnşaa ediliyor
         *
         
         *
         */
        Constructing,

        /**
         *
         * Tamamlandı
         *
         
         *
         */
        Completed,

        /**
         *
         * Kaldırıldı
         *
         
         *
         */
        Removed,
    }
}
