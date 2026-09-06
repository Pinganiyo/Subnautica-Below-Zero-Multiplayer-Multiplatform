namespace Subnautica.Network.Models.Metadata
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class FiltrationMachine : MetadataComponent
    {
        /**
         *
         * IsUnderwater değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsUnderwater { get; set; } = true;

        /**
         *
         * RemovingItemId değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public string RemovingItemId { get; set; }

        /**
         *
         * TimeRemainingWater değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public float TimeRemainingWater { get; set; } = 840f;

        /**
         *
         * TimeRemainingSalt değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public float TimeRemainingSalt { get; set; } = 420f;

        /**
         *
         * TimeRemainingSalt değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public FiltrationMachineItem Item { get; set; }

        /**
         *
         * Thermoses değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public List<FiltrationMachineItem> Items { get; set; } = new List<FiltrationMachineItem>()
        {
            new FiltrationMachineItem(TechType.BigFilteredWater),
            new FiltrationMachineItem(TechType.BigFilteredWater),
            new FiltrationMachineItem(TechType.Salt),
            new FiltrationMachineItem(TechType.Salt),
        };
    }

    [MessagePackObject]
    public class FiltrationMachineItem
    {
        /**
         *
         * IsActive değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public TechType TechType { get; set; }

        /**
         *
         * ItemId değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public string ItemId { get; set; } = null;

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public FiltrationMachineItem()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public FiltrationMachineItem(TechType techType)
        {
            this.TechType = techType;
        }

        /**
         *
         * Temizler.
         *
         
         *
         */
        public void Clear()
        {
            this.ItemId = null;
        }
    }

    [MessagePackObject]
    public class FiltrationMachineTimeItem
    {
        /**
         *
         * TimeRemainingWater değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public uint ConstructionIndex { get; set; }

        /**
         *
         * TimeRemainingWater değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public float TimeRemainingWater { get; set; }

        /**
         *
         * TimeRemainingSalt değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public float TimeRemainingSalt { get; set; }

        /**
         *
         * Items Değerini barındırır.
         *
         
         *
         */
        [IgnoreMember]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public FiltrationMachineTimeItem()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public FiltrationMachineTimeItem(uint constructionIndex, float timeRemainingWater, float timeRemainingSalt, ZeroVector3 position)
        {
            this.ConstructionIndex  = constructionIndex;
            this.TimeRemainingWater = timeRemainingWater;
            this.TimeRemainingSalt  = timeRemainingSalt;
            this.Position = position;
        }
    }
}
