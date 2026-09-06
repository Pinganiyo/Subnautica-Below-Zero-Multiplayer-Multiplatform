namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Crafter : MetadataComponent
    {
        /**
         *
         * IsOpened değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsOpened { get; set; }

        /**
         *
         * IsPickup değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool IsPickup { get; set; }

        /**
         *
         * CraftingTechType değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public TechType CraftingTechType { get; set; }

        /**
         *
         * CraftingDuration değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public float CraftingDuration { get; set; }

        /**
         *
         * CraftingEndTime değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public float CraftingStartTime { get; set; }

        /**
         *
         * CrafterClone değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public Crafter CrafterClone { get; set; }

        /**
         *
         * Zanaatkarı açar.
         *
         
         *
         */
        public bool Open()
        {
            this.IsOpened = true;
            return true;
        }

        /**
         *
         * Zanaatkarı kapatır.
         *
         
         *
         */
        public bool Close()
        {
            this.IsOpened = false;
            return true;
        }

        /**
         *
         * Zanaatkarlığı başlatır.
         *
         
         *
         */
        public bool Craft(TechType techType, float startTime, float duration)
        {
            if (this.CraftingTechType != TechType.None)
            {
                return false;
            }

            this.CraftingTechType  = techType;
            this.CraftingStartTime = startTime;
            this.CraftingDuration  = duration;
            return true;
        }

        /**
         *
         * Nesneyi alır. başlatır.
         *
         
         *
         */
        public bool TryPickup()
        {
            if (this.CraftingTechType == TechType.None)
            {
                return false;
            }

            this.CraftingTechType  = TechType.None;
            this.CraftingStartTime = 0f;
            this.CraftingDuration  = 0f;
            return true;
        }
    }
}
