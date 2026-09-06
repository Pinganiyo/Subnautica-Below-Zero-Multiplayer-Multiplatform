namespace Subnautica.API.Features.Creatures.Datas
{
    using Subnautica.API.Features.Creatures.MonoBehaviours.Shared;

    public class ShadowLeviathanData : BaseCreatureData
    {
        /**
         *
         * Yaratık Türü
         *
         
         *
         */
        public override TechType CreatureType { get; set; } = TechType.ShadowLeviathan;

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
        public override float Health { get; set; } = 5000f;

        /**
         *
         * Yaratık Görünür mesafesi
         *
         
         *
         */
        public override float VisibilityDistance { get; set; } = 200f;

        /**
         *
         * Yaratık Gözükmeme mesafe
         *
         
         *
         */
        public override float VisibilityLongDistance { get; set; } = 250f;

        /**
         *
         * Pasifken Tasma Pozisyonunda Kalması için gereken uzaklık
         *
         
         *
         */
        public override float StayAtLeashPositionWhenPassive { get; set; } = 100f;

        /**
         *
         * Pasifken Tasma Pozisyonuna kaç saniye sonra ışınlanacak?
         *
         
         *
         */
        public override float StayAtLeashPositionTime { get; set; } = 15000f;

        /**
         *
         * Öldükten sonra yeniden canlanabilir mi?
         *
         
         *
         */
        public override bool IsRespawnable { get; set; } = false;

        /**
         *
         * Fast Sync (Daha iyi yaratık senkronizasyonu, Fakat 2x bant genişliği tüketimi)
         *
         
         *
         */
        public override bool IsFastSyncActivated { get; set; } = true;

        /**
         *
         * MonoBehaviour'ları entegre eder. (Client Side)
         *
         
         *
         */
        public override void OnRegisterMonoBehaviours(MultiplayerCreature creature)
        {
            base.OnRegisterMonoBehaviours(creature);

            creature.GameObject.EnsureComponent<MultiplayerMeleeAttack>().SetMultiplayerCreature(creature);
            creature.GameObject.EnsureComponent<MultiplayerAttackLastTarget>().SetMultiplayerCreature(creature);
            creature.GameObject.EnsureComponent<MultiplayerLeviathanMeleeAttack>().SetMultiplayerCreature(creature);
        }
    }
}
