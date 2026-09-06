namespace Subnautica.API.Features.Creatures.Datas
{
    public class TitanHolefishData : BaseCreatureData
    {
        /**
         *
         * Yaratık Türü
         *
         
         *
         */  
        public override TechType CreatureType { get; set; } = TechType.TitanHolefish;

        /**
         *
         * Yaratık Hasar alabilir mi?
         *
         
         *
         */  
        public override bool IsCanBeAttacked { get; set; } = true;

        /**
         *
         * Yaratık Sağlığı
         *
         
         *
         */  
        public override float Health { get; set; } = 2000f;

        /**
         *
         * Yaratık Görünür mesafesi
         *
         
         *
         */  
        public override float VisibilityDistance { get; set; } = 90f;

        /**
         *
         * Yaratık Gözükmeme max mesafe
         *
         
         *
         */  
        public override float VisibilityLongDistance { get; set; } = 110f;

        /**
         *
         * Pasifken Tasma Pozisyonunda Kalması için gereken uzaklık
         *
         
         *
         */  
        public override float StayAtLeashPositionWhenPassive { get; set; } = 70f;

        /**
         *
         * Öldükten sonra yeniden canlanabilir mi?
         *
         
         *
         */
        public override bool IsRespawnable { get; set; } = true;

        /**
         *
         * Yaratık Respawn Time (Min)
         *
         
         *
         */
        public override int RespawnTimeMin { get; set; } = 600;

        /**
         *
         * Yaratık Respawn Time (Max)
         *
         
         *
         */  
        public override int RespawnTimeMax { get; set; } = 600;
    }
}
