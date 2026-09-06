namespace Subnautica.Network.Structures
{
    using MessagePack;

    using Subnautica.API.Extensions;
    using Subnautica.API.Features;

    using UnityEngine;

    [MessagePackObject]
    public class ZeroLastTarget
    {
        /**
         *
         * TargetId değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public string TargetId { get; set; }

        /**
         *
         * Type değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public TechType Type { get; set; }

        /**
         *
         * IsDead değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsDead { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroLastTarget()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroLastTarget(string targetId, TechType type)
        {
            this.TargetId = targetId;
            this.Type     = type;
        }

        /**
         *
         * Ölüm durumunu değiştirir.
         *
         
         *
         */
        public void Kill()
        {
            this.IsDead = true;
        }

        /**
         *
         * Oyun nesnesini döner.
         *
         
         *
         */
        public GameObject GetGameObject(bool supressMessage = false)
        {
            return Network.Identifier.GetGameObject(this.TargetId, supressMessage);
        }

        /**
         *
         * Oyuncu mu?
         *
         
         *
         */
        public bool IsPlayer()
        {
            return this.Type.IsPlayer();
        }

        /**
         *
         * Yaratık mu?
         *
         
         *
         */
        public bool IsCreature()
        {
            return this.Type.IsCreature();
        }

        /**
         *
         * Araç mı?
         *
         
         *
         */
        public bool IsVehicle()
        {
            return this.Type.IsVehicle();
        }

        /**
         *
         * Seatruck olup olmadığını döner.
         *
         
         *
         */
        public bool IsSeatruck()
        {
            return this.Type == TechType.SeaTruck;
        }

        /**
         *
         * Exosuit olup olmadığını döner.
         *
         
         *
         */
        public bool IsExosuit()
        {
            return this.Type == TechType.Exosuit;
        }
    }
}
