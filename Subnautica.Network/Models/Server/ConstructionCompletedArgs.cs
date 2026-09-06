namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class ConstructionCompletedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ConstructingCompleted;
        
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
         * Yapı Id Kimliği Pozisyonu
         *
         
         *
         */
        [Key(5)]
        public uint Id { get; set; }

        /**
         *
         * Ağ Kimliği Pozisyonu
         *
         
         *
         */
        [Key(6)]
        public string UniqueId { get; set; }

        /**
         *
         * Base Kimliği
         *
         
         *
         */
        [Key(7)]
        public string BaseId { get; set; }

        /**
         *
         * Nesne Türü
         *
         
         *
         */
        [Key(8)]
        public TechType TechType { get; set; }

        /**
         *
         * CellPosition Değeri
         *
         
         *
         */
        [Key(9)]
        public ZeroVector3 CellPosition { get; set; }

        /**
         *
         * LocalPosition Değeri
         *
         
         *
         */
        [Key(10)]
        public ZeroVector3 LocalPosition { get; set; }

        /**
         *
         * LocalRotation Değeri
         *
         
         *
         */
        [Key(11)]
        public ZeroQuaternion LocalRotation { get; set; }

        /**
         *
         * IsFaceHasValue Değeri
         *
         
         *
         */
        [Key(12)]
        public bool IsFaceHasValue { get; set; }

        /**
         *
         * FaceDirection Değeri
         *
         
         *
         */
        [Key(13)]
        public Base.Direction FaceDirection { get; set; }

        /**
         *
         * FaceType Değeri
         *
         
         *
         */
        [Key(14)]
        public Base.FaceType FaceType { get; set; }
    }
}
