namespace Subnautica.Network.Models.Server
{
    using LiteNetLib;
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    using System.Collections.Generic;

    [MessagePackObject]
    public class CreatureAnimationArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.CreatureAnimation;

        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.FishMovement;

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
         * Animations Değeri
         *
         
         *
         */
        [Key(5)]
        public HashSet<CreatureAnimationItem> Animations { get; set; } = new HashSet<CreatureAnimationItem>();
    }

    [MessagePackObject]
    public class CreatureAnimationItem
    {
        /**
         *
         * CreatureId Değeri
         *
         
         *
         */
        [Key(0)]
        public ushort CreatureId { get; set; }

        /**
         *
         * Animations Değeri
         *
         
         *
         */
        [Key(1)]
        public Dictionary<byte, byte> Animations = new Dictionary<byte, byte>();
    }
}
