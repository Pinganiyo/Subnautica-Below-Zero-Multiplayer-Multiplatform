namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Models.Storage.World.Childrens;

    [MessagePackObject]
    public class BrinicleArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.Brinicle;

        /**
         *
         * UniqueIds Değeri
         *
         
         *
         */
        [Key(5)]
        public List<Brinicle> WaitingForRegistry { get; set; } = new List<Brinicle>();

        /**
         *
         * Brinicles Değeri
         *
         
         *
         */
        [Key(6)]
        public List<Brinicle> Brinicles { get; set; } = new List<Brinicle>();

        /**
         *
         * UniqueId Değeri
         *
         
         *
         */
        [Key(7)]
        public string UniqueId { get; set; }

        /**
         *
         * Damage Değeri
         *
         
         *
         */
        [Key(8)]
        public float Damage { get; set; } 
    }
}