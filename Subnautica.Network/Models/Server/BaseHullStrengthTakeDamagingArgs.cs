namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class BaseHullStrengthTakeDamagingArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.BaseHullStrength;

        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.Construction;

        /**
         *
         * Packet Kanal Id
         *
         
         *
         */
        [Key(3)]
        public override byte ChannelId { get; set; } = 1;

        /**
         *
         * UniqueId Değerini Barındırır.
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * Damage Değerini Barındırır.
         *
         
         *
         */
        [Key(6)]
        public float Damage { get; set; }

        /**
         *
         * DamageType Değerini Barındırır.
         *
         
         *
         */
        [Key(7)]
        public DamageType DamageType { get; set; }

        /**
         *
         * CurrentHealth Değerini Barındırır.
         *
         
         *
         */
        [Key(8)]
        public float CurrentHealth { get; set; }

        /**
         *
         * MaxHealth Değerini Barındırır.
         *
         
         *
         */
        [Key(9)]
        public float MaxHealth { get; set; }

        /**
         *
         * LeakPoints Değerini Barındırır.
         *
         
         *
         */
        [Key(10)]
        public List<ZeroVector3> LeakPoints { get; set; }
    }
}
