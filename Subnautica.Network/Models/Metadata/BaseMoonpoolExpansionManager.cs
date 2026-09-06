namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.API.Extensions;
    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class BaseMoonpoolExpansionManager : MetadataComponent
    {
        /**
         *
         * TailId Değeri
         *
         
         *
         */
        [Key(0)]
        public string TailId { get; set; }

        /**
         *
         * Kuyruğu demirler.
         *
         
         *
         */
        public void DockTail(string tailId)
        {
            this.TailId = tailId;
        }

        /**
         *
         * Kuyruğu kaldırır.
         *
         
         *
         */
        public void UndockTail()
        {
            this.TailId = null;
        }

        /**
         *
         * Kuyruğu demirlenmiş mi?
         *
         
         *
         */
        public bool IsTailDocked()
        {
            return this.TailId.IsNotNull();
        }
    }
}