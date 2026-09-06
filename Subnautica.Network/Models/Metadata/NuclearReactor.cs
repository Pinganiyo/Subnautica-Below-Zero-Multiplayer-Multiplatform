namespace Subnautica.Network.Models.Metadata
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class NuclearReactor : MetadataComponent
    {
        /**
         *
         * IsRemoving Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsRemoving { get; set; } = false;

        /**
         *
         * Item Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public List<TechType> Items { get; set; } = new List<TechType>();
    }
}
