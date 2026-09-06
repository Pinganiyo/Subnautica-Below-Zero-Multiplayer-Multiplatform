namespace Subnautica.Network.Models.WorldEntity
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;

#pragma warning disable CS0612

    [MessagePackObject]
    public class Elevator : NetworkWorldEntityComponent
    {
        /**
         *
         * ProcessType değeri
         *
         
         *
         */
        [Key(2)]
        public override EntityProcessType ProcessType { get; set; } = EntityProcessType.Elevator;

        /**
         *
         * IsUp değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsUp { get; set; }

        /**
         *
         * StartTime değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public float StartTime { get; set; }
    }
}