namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class SeaTruckConnectionArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.SeaTruckConnection;

        /**
         *
         * IsConnect Değeri
         *
         
         *
         */
        [Key(5)]
        public bool IsConnect { get; set; }

        /**
         *
         * IsEject Değeri
         *
         
         *
         */
        [Key(6)]
        public bool IsEject { get; set; }

        /**
         *
         * IsMoonpoolExpansion Değeri
         *
         
         *
         */
        [Key(7)]
        public bool IsMoonpoolExpansion { get; set; }

        /**
         *
         * FrontModuleId Değeri
         *
         
         *
         */
        [Key(8)]
        public string FrontModuleId { get; set; }

        /**
         *
         * BackModuleId Değeri
         *
         
         *
         */
        [Key(9)]
        public string BackModuleId { get; set; }

        /**
         *
         * FirstModuleId Değeri
         *
         
         *
         */
        [Key(10)]
        public string FirstModuleId { get; set; }

        /**
         *
         * ModuleId Değeri
         *
         
         *
         */
        [Key(11)]
        public ushort ModuleId { get; set; }

        /**
         *
         * Position Değeri
         *
         
         *
         */
        [Key(12)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation Değeri
         *
         
         *
         */
        [Key(13)]
        public ZeroQuaternion Rotation { get; set; }
    }
}
