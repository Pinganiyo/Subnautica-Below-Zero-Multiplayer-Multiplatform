namespace Subnautica.Network.Models.Construction
{
    using MessagePack;

    using Subnautica.Network.Models.Construction.Shared;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class BaseAddCellGhostComponent : BaseGhostComponent
    {
        /**
         *
         * TargetOffset değeri
         *
         
         *
         */
        [Key(2)]
        public ZeroInt3 TargetOffset { get; set; }

        /**
         *
         * AboveFaceType değeri
         *
         
         *
         */
        [Key(3)]
        public global::Base.FaceType AboveFaceType { get; set; }

        /**
         *
         * BelowFaceType değeri
         *
         
         *
         */
        [Key(4)]
        public global::Base.FaceType BelowFaceType { get; set; }
    }
}
