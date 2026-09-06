namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class CreatureProcessArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.CreatureProcess;

        /**
         *
         * ProcessTime değeri
         *
         
         *
         */
        [Key(5)]
        public double ProcessTime { get; set; }

        /**
         *
         * CreatureId değeri
         *
         
         *
         */
        [Key(6)]
        public ushort CreatureId { get; set; }

        /**
         *
         * CreatureType değeri
         *
         
         *
         */
        [Key(7)]
        public TechType CreatureType { get; set; }

        /**
         *
         * Component değeri
         *
         
         *
         */
        [Key(8)]
        public NetworkCreatureComponent Component { get; set; }
    }
}