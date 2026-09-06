namespace Subnautica.Network.Models.Server
{
    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class WeatherChangedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.WeatherChanged;

        /**
         *
         * DangerLevel değeri
         *
         
         *
         */
        [Key(5)]
        public WeatherDangerLevel DangerLevel { get; set; }

        /**
         *
         * StartTime değeri
         *
         
         *
         */
        [Key(6)]
        public float StartTime { get; set; }

        /**
         *
         * Duration değeri
         *
         
         *
         */
        [Key(7)]
        public float Duration { get; set; }

        /**
         *
         * WindDir değeri
         *
         
         *
         */
        [Key(8)]
        public float WindDir { get; set; }

        /**
         *
         * WindSpeed değeri
         *
         
         *
         */
        [Key(9)]
        public float WindSpeed { get; set; }

        /**
         *
         * FogDensity değeri
         *
         
         *
         */
        [Key(10)]
        public float FogDensity { get; set; }

        /**
         *
         * FogHeight değeri
         *
         
         *
         */
        [Key(11)]
        public float FogHeight { get; set; }

        /**
         *
         * SmokinessIntensity değeri
         *
         
         *
         */
        [Key(12)]
        public float SmokinessIntensity { get; set; }

        /**
         *
         * SnowIntensity değeri
         *
         
         *
         */
        [Key(13)]
        public float SnowIntensity { get; set; }

        /**
         *
         * CloudCoverage değeri
         *
         
         *
         */
        [Key(14)]
        public float CloudCoverage { get; set; }

        /**
         *
         * RainIntensity değeri
         *
         
         *
         */
        [Key(15)]
        public float RainIntensity { get; set; }

        /**
         *
         * HailIntensity değeri
         *
         
         *
         */
        [Key(16)]
        public float HailIntensity { get; set; }

        /**
         *
         * MeteorIntensity değeri
         *
         
         *
         */
        [Key(17)]
        public float MeteorIntensity { get; set; }

        /**
         *
         * LightningIntensity değeri
         *
         
         *
         */
        [Key(18)]
        public float LightningIntensity { get; set; }

        /**
         *
         * Temperature değeri
         *
         
         *
         */
        [Key(19)]
        public float Temperature { get; set; }

        /**
         *
         * AuroraBorealisIntensity değeri
         *
         
         *
         */
        [Key(20)]
        public float AuroraBorealisIntensity { get; set; }

        /**
         *
         * IsProfile değeri
         *
         
         *
         */
        [Key(21)]
        public bool IsProfile { get; set; }
    }
}