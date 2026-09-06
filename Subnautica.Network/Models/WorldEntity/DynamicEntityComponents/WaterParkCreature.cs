namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class WaterParkCreature : NetworkDynamicEntityComponent
    {
        /**
         *
         * AddedTime Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public double AddedTime { get; set; }

        /**
         *
         * WaterParkId Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public string WaterParkId { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public WaterParkCreature()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public WaterParkCreature(double addedTime, string waterParkId)
        {
            this.AddedTime   = addedTime;
            this.WaterParkId = waterParkId;
        }

        /**
         *
         * Yumurta doğma zamanını değiştirir.
         *
         
         *
         */
        public void SpawnChildren(double currentTime)
        {
            this.AddedTime = currentTime;
        }

        /**
         *
         * Doğabilir mi?
         *
         
         *
         */
        public bool IsSpawnable(double currentTime)
        {
            return currentTime - this.AddedTime >= 1200;
        }
    }
}