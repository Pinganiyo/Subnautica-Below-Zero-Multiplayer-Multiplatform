namespace Subnautica.Network.Models.WorldEntity
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class OxygenPlant : NetworkWorldEntityComponent
    {
        /**
         *
         * ProcessType değeri
         *
         
         *
         */
        [Key(2)]
        public override EntityProcessType ProcessType { get; set; } = EntityProcessType.OxygenPlant;

        /**
         *
         * StartedTime değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public float StartedTime { get; set; }
    }
}