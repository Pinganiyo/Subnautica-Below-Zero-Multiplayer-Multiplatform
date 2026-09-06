namespace Subnautica.API.Features.Creatures.Datas
{
    using System.Collections;
    using System.Collections.Generic;

    using Subnautica.API.Enums;
    using Subnautica.API.Features.Creatures.MonoBehaviours;
    using Subnautica.API.Features.Creatures.MonoBehaviours.Shared;
    using Subnautica.API.Features.Creatures.Trackers;

    using UnityEngine;

    using UWE;

    public abstract class BaseCreatureData
    {
        /**
         *
         * Yaratık Türü
         *
         
         *
         */
        public abstract TechType CreatureType { get; set; }

        /**
         *
         * Yaratık Hasar alabilir mi?
         *
         
         *
         */
        public abstract bool IsCanBeAttacked { get; set; }

        /**
         *
         * Yaratık Sağlığı
         *
         
         *
         */
        public abstract float Health { get; set; }

        /**
         *
         * Yaratık Görünür mesafesi
         *
         
         *
         */
        public abstract float VisibilityDistance { get; set; }

        /**
         *
         * Yaratık Gözükmeme max mesafe
         *
         
         *
         */
        public abstract float VisibilityLongDistance { get; set; }

        /**
         *
         * Öldükten sonra yeniden canlanabilir mi?
         *
         
         *
         */
        public abstract bool IsRespawnable { get; set; }

        /**
         *
         * Pasifken Tasma Pozisyonunda Kalması için gereken uzaklık
         *
         
         *
         */
        public abstract float StayAtLeashPositionWhenPassive { get; set; }

        /**
         *
         * Pasifken Tasma Pozisyonuna kaç saniye sonra ışınlanacak?
         *
         
         *
         */
        public virtual float StayAtLeashPositionTime { get; set; } = 30000f;

        /**
         *
         * Yaratık Respawn Time (Min)
         *
         
         *
         */
        public virtual int RespawnTimeMin { get; set; }

        /**
         *
         * Yaratık Respawn Time (Max)
         *
         
         *
         */
        public virtual int RespawnTimeMax { get; set; }

        /**
         *
         * Fast Sync (Daha iyi yaratık senkronizasyonu, Fakat 2x bant genişliği tüketimi)
         *
         
         *
         */
        public virtual bool IsFastSyncActivated { get; set; }

        /**
         *
         * Doğma Seviyesi
         *
         
         *
         */
        public virtual CreatureSpawnLevel SpawnLevel { get; set; } = CreatureSpawnLevel.Default;

        /**
         *
         * Animasyon index numrasını barındırır.
         *
         
         *
         */
        private byte CurrentAnimationIndex = 0;

        /**
         *
         * Animasyon izleyici olayını barındırır.
         *
         
         *
         */
        public delegate bool AnimationTrackerAction<T1, T2, T3, T4>(T1 a, T2 b, T3 c, out T4 d);

        /**
         *
         * Animasyon izleyicilerini barındırır.
         *
         
         *
         */
        private Dictionary<byte, BaseAnimationTracker> AnimationTrackers { get; set; } = new Dictionary<byte, BaseAnimationTracker>();

        /**
         *
         * MonoBehaviour'ları entegre eder. (Client Side)
         *
         
         *
         */
        public virtual void OnRegisterMonoBehaviours(MultiplayerCreature creature)
        {
            creature.GameObject.EnsureComponent<MultiplayerCreaturedShared>().SetMultiplayerCreature(creature);
        }

        /**
         *
         * Özel bir yaratık spawnlanmak için kullanılır. (Async)
         *
         
         *
         */
        public virtual IEnumerator OnCustomCreatureSpawnAsync(TaskResult<GameObject> task)
        {
            task.Set(null);
            yield return null;
        }

        /**
         *
         * Özel bir yaratık spawnlanmak için kullanılır.
         *
         
         *
         */
        public virtual GameObject OnCustomCreatureSpawn()
        {
            return null;
        }

        /**
         *
         * Yaratık kukla öldüğünde tetiklenir.
         *
         
         *
         */
        public virtual bool OnKill(GameObject gameObject)
        {
            return true;
        }

        /**
         *
         * Animasyon izleyicisi ekler.
         *
         
         *
         */
        public void AddAnimationTracker(BaseAnimationTracker tracker)
        {
            if (this.CurrentAnimationIndex < 250)
            {
                this.AnimationTrackers[++this.CurrentAnimationIndex] = tracker;
            }
            else
            {
                Log.Error($"Sooo much animation: {this.CurrentAnimationIndex}");
            }
        }
        /**
         *
         * Görünürlük mesafesini döner.
         *
         
         *
         */
        public float GetVisibilityDistance(bool longDistance = false)
        {
            if (longDistance)
            {
                return this.VisibilityLongDistance * this.VisibilityLongDistance;
            }

            return this.VisibilityDistance * this.VisibilityDistance;
        }

        /**
         *
         * Yaratık Canlanma zamanını döner.
         *
         
         *
         */
        public int GetRespawnDuration()
        {
            if (this.RespawnTimeMin == this.RespawnTimeMax)
            {
                return this.RespawnTimeMin;
            }

            return Tools.Random.Next(this.RespawnTimeMin, this.RespawnTimeMax);
        }

        /**
         *
         * Animasyonlara sahip mi?.
         *
         
         *
         */
        public bool HasAnimationTrackers()
        {
            return this.CurrentAnimationIndex > 0;
        }

        /**
         *
         * Animasyon adını döner.
         *
         
         *
         */
        public BaseAnimationTracker GetAnimationTrackerById(byte animationId)
        {
            this.AnimationTrackers.TryGetValue(animationId, out var tracker);
            return tracker;
        }

        /**
         *
         * Animasyonları izleyicilerini döner.
         *
         
         *
         */
        public Dictionary<byte, BaseAnimationTracker> GetAnimationTrackers()
        {
            return this.AnimationTrackers;
        }
    }
}
