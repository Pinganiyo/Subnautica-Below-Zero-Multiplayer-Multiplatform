namespace Subnautica.Network.Models.Construction
{
    using MessagePack;

    using Subnautica.Network.Models.Construction.Shared;

    [MessagePackObject]
    public class BaseAddLadderGhostComponent : BaseGhostComponent
    {
        /**
         *
         * FaceStart değeri
         *
         
         *
         */
        [Key(2)]
        public BaseFaceComponent FaceStart { get; set; }

        /**
         *
         * FaceEnd değeri
         *
         
         *
         */
        [Key(3)]
        public BaseFaceComponent FaceEnd { get; set; }
    }
}
