namespace Subnautica.API.Features.Creatures.Datas
{
    using Subnautica.API.Features.Creatures.MonoBehaviours;

    public class VentGardenSmallData : BaseCreatureData
    {
        /**
         *
         * Yaratık Türü
         *
         
         *
         */  
        public override TechType CreatureType { get; set; } = TechType.SmallVentGarden;

        /**
         *
         * Yaratık Hasar alabilir mi?
         *
         
         *
         */  
        public override bool IsCanBeAttacked { get; set; } = false;

        /**
         *
         * Yaratık Sağlığı
         *
         
         *
         */  
        public override float Health { get; set; } = 1f;

        /**
         *
         * Yaratık Görünür mesafesi
         *
         
         *
         */  
        public override float VisibilityDistance { get; set; } = 120f;

        /**
         *
         * Yaratık Gözükmeme max mesafe
         *
         
         *
         */  
        public override float VisibilityLongDistance { get; set; } = 150f;

        /**
         *
         * Pasifken Tasma Pozisyonunda Kalması için gereken uzaklık
         *
         
         *
         */  
        public override float StayAtLeashPositionWhenPassive { get; set; } = 111f;

        /**
         *
         * Öldükten sonra yeniden canlanabilir mi?
         *
         
         *
         */
        public override bool IsRespawnable { get; set; } = false;
    }
}
