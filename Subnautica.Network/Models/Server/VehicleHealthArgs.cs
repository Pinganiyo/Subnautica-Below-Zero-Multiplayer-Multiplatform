namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class VehicleHealthArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleHealth;

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * Damage Değeri
         *
         
         *
         */
        [Key(6)]
        public float Damage { get; set; }

        /**
         *
         * NewHealth Değeri
         *
         
         *
         */
        [Key(7)]
        public float NewHealth { get; set; }

        /**
         *
         * DamageType Değeri
         *
         
         *
         */
        [Key(8)]
        public DamageType DamageType { get; set; }
    }
}
