using System;
using System.Collections.Generic;
namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class VehicleUpgradeConsoleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleUpgradeConsole;

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        [Key(5)]
        public string UniqueId { get; set; }

        /**
         *
         * ItemId değeri
         *
         
         *
         */
        [Key(6)]
        public string ItemId { get; set; }

        /**
         *
         * SlotId değeri
         *
         
         *
         */
        [Key(7)]
        public string SlotId { get; set; }

        /**
         *
         * IsOpening değeri
         *
         
         *
         */
        [Key(8)]
        public bool IsOpening { get; set; }

        /**
         *
         * IsAdding değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsAdding { get; set; }

        /**
         *
         * ModuleType değeri
         *
         
         *
         */
        [Key(10)]
        public TechType ModuleType { get; set; }
    }
}