namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class CreatureLeviathanMeleeAttackArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.CreatureLeviathanMeleeAttack;

        /**
         *
         * CreatureId Değerini Barındırır.
         *
         
         *
         */
        [Key(5)]
        public ushort CreatureId { get; set; }

        /**
         *
         * BiteDamage Değerini Barındırır.
         *
         
         *
         */
        [Key(6)]
        public float BiteDamage { get; set; }

        /**
         *
         * ProcessTime Değerini Barındırır.
         *
         
         *
         */
        [Key(7)]
        public double ProcessTime { get; set; }

        /**
         *
         * Target Değerini Barındırır.
         *
         
         *
         */
        [Key(8)]
        public ZeroLastTarget Target { get; set; }
    }
}
