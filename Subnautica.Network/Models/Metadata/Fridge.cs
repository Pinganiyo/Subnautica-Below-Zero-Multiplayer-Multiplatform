namespace Subnautica.Network.Models.Metadata
{
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;

    [MessagePackObject]
    public class Fridge : MetadataComponent
    {
        /**
         *
         * IsAdded değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsAdded { get; set; }

        /**
         *
         * IsPowerStateChanged değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool IsPowerStateChanged { get; set; }

        /**
         *
         * WasPowered değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool WasPowered { get; set; }

        /**
         *
         * CurrentTime değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public float CurrentTime { get; set; }

        /**
         *
         * IsDecomposes değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsDecomposes { get; set; }

        /**
         *
         * TimeDecayStart değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public float TimeDecayStart { get; set; } = 0.0f;

        /**
         *
         * ItemComponent değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public FridgeItemComponent ItemComponent { get; set; }

        /**
         *
         * WorldPickupItem değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public WorldPickupItem WorldPickupItem { get; set; }

        /**
         *
         * StorageContainer değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public Metadata.StorageContainer StorageContainer { get; set; }

        /**
         *
         * Components değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public List<FridgeItemComponent> Components { get; set; } = new List<FridgeItemComponent>();
    }

    [MessagePackObject]
    public class FridgeItemComponent
    {
        /**
         *
         * ItemId değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public string ItemId { get; set; }

        /**
         *
         * IsPaused değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public bool IsPaused { get; set; }

        /**
         *
         * IsDecomposes değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsDecomposes { get; set; }

        /**
         *
         * TimeDecayPause değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public float TimeDecayPause { get; set; } = 0.0f;

        /**
         *
         * TimeDecayStart değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public float TimeDecayStart { get; set; } = 0.0f;

        /**
         *
         * Çürümeyi durdurur.
         *
         
         *
         */
        public void PauseDecay(float serverTime)
        {
            if (!this.IsPaused)
            {
                this.IsPaused = true;
                this.TimeDecayPause = serverTime;
            }
        }

        /**
         *
         * Çürümeyi başlatır.
         *
         
         *
         */
        public void UnpauseDecay(float serverTime)
        {
            if (this.IsPaused)
            {
                this.IsPaused = false;
                this.TimeDecayStart += serverTime - this.TimeDecayPause;
           }
        }
    }
}