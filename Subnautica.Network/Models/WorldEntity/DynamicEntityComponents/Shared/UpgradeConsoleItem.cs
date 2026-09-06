namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared
{
    using MessagePack;

    [MessagePackObject]
    public class UpgradeConsoleItem
    {
        /**
         *
         * ItemId Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public string ItemId { get; set; }

        /**
         *
         * ModuleType Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public TechType ModuleType { get; set; }
    }
}
