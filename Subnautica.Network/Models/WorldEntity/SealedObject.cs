namespace Subnautica.Network.Models.WorldEntity
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class SealedObject : NetworkWorldEntityComponent
    {
        /**
         *
         * ProcessType değeri
         *
         
         *
         */
        [Key(2)]
        public override EntityProcessType ProcessType { get; set; } = EntityProcessType.SealedObject;

        /**
         *
         * IsSealed değeri
         *
         
         *
         */
        [Key(4)]
        public bool IsSealed { get; set; }

        /**
         *
         * Amount değeri
         *
         
         *
         */
        [Key(5)]
        public float Amount { get; set; }

        /**
         *
         * MaxAmount değeri
         *
         
         *
         */
        [Key(6)]
        public float MaxAmount { get; set; }
    }
}