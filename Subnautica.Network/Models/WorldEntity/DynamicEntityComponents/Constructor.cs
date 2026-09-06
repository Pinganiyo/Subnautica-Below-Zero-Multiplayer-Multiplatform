namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Constructor : NetworkDynamicEntityComponent
    {
        /**
         *
         * IsLightActive Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsDeployed { get; set; } = true;

        /**
         *
         * CraftingFinishTime Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public float CraftingFinishTime { get; set; }

        /**
         *
         * Nesne oluşturma yapılabilir mi?
         *
         
         *
         */
        public bool IsCraftable(float currentTime)
        {
            return currentTime >= this.CraftingFinishTime;
        }
    }
}