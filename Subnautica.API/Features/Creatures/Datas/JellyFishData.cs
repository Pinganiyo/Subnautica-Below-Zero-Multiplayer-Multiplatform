namespace Subnautica.API.Features.Creatures.Datas
{
    using Subnautica.API.Features.Creatures.MonoBehaviours;

    public class JellyFishData : BaseCreatureData
    {
        /**
         *
         * Yaratık Türü
         *
         
         *
         */  
        public override TechType CreatureType { get; set; } = TechType.Jellyfish;

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
        public override float Health { get; set; } = 200f;

        /**
         *
         * Yaratık Görünür mesafesi
         *
         
         *
         */  
        public override float VisibilityDistance { get; set; } = 100f;

        /**
         *
         * Yaratık Gözükmeme mesafe
         *
         
         *
         */  
        public override float VisibilityLongDistance { get; set; } = 125f;

        /**
         *
         * Pasifken Tasma Pozisyonunda Kalması için gereken uzaklık
         *
         
         *
         */  
        public override float StayAtLeashPositionWhenPassive { get; set; } = 80f;

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

        /**
         *
         * MonoBehaviour'ları entegre eder. (Client Side)
         *
         
         *
         */
        public override void OnRegisterMonoBehaviours(MultiplayerCreature creature)
        {
            base.OnRegisterMonoBehaviours(creature);
            
            creature.GameObject.EnsureComponent<JellyFishMonobehaviour>().SetMultiplayerCreature(creature);
        }
    }
}
