namespace Subnautica.Network.Models.Server
{
    using LiteNetLib;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class CreatureCallArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.CreatureCallSound;

        /**
         *
         * Packet Teslim Türü
         *
         
         *
         */
        [Key(2)]
        public override DeliveryMethod DeliveryMethod { get; set; } = DeliveryMethod.Unreliable;

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
         * CallId Değerini Barındırır.
         *
         
         *
         */
        [Key(6)]
        public byte CallId { get; set; }

        /**
         *
         * Animation Değerini Barındırır.
         *
         
         *
         */
        [Key(7)]
        public string Animation { get; set; }
    }
}