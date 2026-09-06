namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using System.Collections.Generic;

    [MessagePackObject]
    public class InventoryEquipmentArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.InventoryEquipment;

        /**
         *
         * Ekipmanlar
         *
         
         *
         */
        [Key(5)]
        public byte[] Equipments { get; set; }

        /**
         *
         * Ekipman Slot Id'leri
         *
         
         *
         */
        [Key(6)]
        public Dictionary<string, string> EquipmentSlots { get; set; }
    }
}
