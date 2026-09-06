namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class VehicleInteriorArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleInterior;

        /**
         *
         * VehicleId Değeri
         *
         
         *
         */
        [Key(5)]
        public string VehicleId { get; set; }

        /**
         *
         * IsEntered Değeri
         *
         
         *
         */
        [Key(6)]
        public bool IsEntered { get; set; }
    }
}
