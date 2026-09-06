namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class CreatureHealthArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.CreatureHealth;

        /**
         *
         * Damage Değerini Barındırır.
         *
         
         *
         */
        [Key(5)]
        public ushort CreatureId { get; set; }

        /**
         *
         * IsDead Değerini Barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsDead { get; set; }

        /**
         *
         * Damage Değerini Barındırır.
         *
         
         *
         */
        [Key(7)]
        public float Damage { get; set; }

        /**
         *
         * Damage Değerini Barındırır.
         *
         
         *
         */
        [Key(8)]
        public DamageType DamageType { get; set; }
    }
}
