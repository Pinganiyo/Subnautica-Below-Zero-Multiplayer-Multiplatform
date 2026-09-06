namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using LiteNetLib;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class WorldCreaturePositionArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.WorldCreaturePosition;

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
         * Key Değeri
         *
         
         *
         */
        [Key(5)]
        public List<WorldCreaturePosition> Positions { get; set; } = new List<WorldCreaturePosition>();
    }

    [MessagePackObject]
    public class WorldCreaturePosition
    {
        /**
         *
         * Yapı Kimliği değeri
         *
         
         *
         */
        [Key(0)]
        public ushort CreatureId { get; set; }

        /**
         *
         * Position değeri
         *
         
         *
         */
        [Key(1)]
        public long Position { get; set; }

        /**
         *
         * Item değeri
         *
         
         *
         */
        [Key(2)]
        public long Rotation { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public WorldCreaturePosition()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public WorldCreaturePosition(ushort creatureId, long position, long rotation)
        {
            this.CreatureId = creatureId;
            this.Position   = position;
            this.Rotation   = rotation;
        }
    }
}