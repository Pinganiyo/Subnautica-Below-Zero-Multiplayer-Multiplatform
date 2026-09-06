namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class ScannerCompletedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.ScannerCompleted;

        /**
         *
         * TechType Değeri
         *
         
         *
         */
        [Key(5)]
        public TechType TechType { get; set; }
    }
}
