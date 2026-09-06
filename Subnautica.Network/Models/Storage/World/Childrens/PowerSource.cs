namespace Subnautica.Network.Models.Storage.World.Childrens
{
    using MessagePack;

    using UnityEngine;

    [MessagePackObject]
    public class PowerSource
    {
        /**
         *
         * Mevcut gücü barındırır.
         *
         
         *
         */
        [Key(0)]
        public uint ConstructionId { get; set; }

        /**
         *
         * Mevcut gücü barındırır.
         *
         
         *
         */
        [Key(1)]
        public float Power { get; set; }

        /**
         *
         * Max Gücü barındırır.
         *
         
         *
         */
        [Key(2)]
        public float MaxPower { get; set; }

        /**
         *
         * Tüketilen Enerji miktarını barındırır.
         *
         
         *
         */
        [Key(3)]
        public float ConsumedEnergy { get; set; }

        /**
         *
         * Enerji miktarlarını değiştirir.
         *
         
         *
         */
        public void ModifyPower(float energyAmount)
        {
            this.Power = Mathf.Clamp(this.Power + energyAmount, 0.0f, this.MaxPower);
        }

        /**
         *
         * Tüketilen Enerji miktarlarını değiştirir.
         *
         
         *
         */
        public void ModifyConsumedEnergy(float consumedEnergy)
        {
            this.ConsumedEnergy += consumedEnergy;
        }

        /**
         *
         * Tüketilen Enerji miktarlarını yeni değerle değiştirir.
         *
         
         *
         */
        public void SetConsumedEnergy(float energy)
        {
            this.ConsumedEnergy = energy;
        }
    }
}