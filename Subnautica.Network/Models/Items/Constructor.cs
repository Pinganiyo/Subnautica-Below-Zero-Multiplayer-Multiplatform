namespace Subnautica.Network.Models.Items
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Storage.World.Childrens;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class Constructor : NetworkPlayerItemComponent
    {
        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(1)]
        public override TechType TechType { get; set; } = TechType.Constructor;

        /**
         *
         * Forward Değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public ZeroVector3 Forward { get; set; }

        /**
         *
         * Position Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Entity Değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public WorldDynamicEntity Entity { get; set; }

        /**
         *
         * EngageToggle Değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public byte EngageToggle { get; set; }

        /**
         *
         * CraftingTechType Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public TechType CraftingTechType { get; set; }

        /**
         *
         * CraftingFinishTime Değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public float CraftingFinishTime { get; set; }

        /**
         *
         * CraftingFinishTime Değerini barındırır.
         *
         
         *
         */
        [Key(10)]
        public ZeroVector3 CraftingPosition { get; set; }

        /**
         *
         * CraftingFinishTime Değerini barındırır.
         *
         
         *
         */
        [Key(11)]
        public ZeroQuaternion CraftingRotation { get; set; }
        
        /**
         *
         * EngageToggle aktif olup/olmadığını döner.
         *
         
         *
         */
        public bool IsEngageActive()
        {
            return this.EngageToggle != 0;
        }

        /**
         *
         * Engage olup/olmadığını döner.
         *
         
         *
         */
        public bool IsEngage()
        {
            return this.EngageToggle == 1;
        }
    }
}