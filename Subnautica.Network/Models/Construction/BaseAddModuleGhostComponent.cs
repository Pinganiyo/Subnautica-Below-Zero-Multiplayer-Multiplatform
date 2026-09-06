namespace Subnautica.Network.Models.Construction
{
    using MessagePack;

    using Subnautica.Network.Models.Construction.Shared;

    [MessagePackObject]
    public class BaseAddModuleGhostComponent : BaseGhostComponent
    {
        /**
         *
         * FaceStart değeri
         *
         
         *
         */
        [Key(2)]
        public BaseFaceComponent FaceStart { get; set; }
    }
}
