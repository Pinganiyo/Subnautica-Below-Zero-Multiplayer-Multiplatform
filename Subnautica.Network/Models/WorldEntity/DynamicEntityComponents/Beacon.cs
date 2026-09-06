namespace Subnautica.Network.Models.WorldEntity.DynamicEntityComponents
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Beacon : NetworkDynamicEntityComponent
    {
        /**
         *
         * IsDeployedOnLand Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsDeployedOnLand { get; set; }

        /**
         *
         * Text Değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public string Text { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public Beacon()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public Beacon(bool isDeployedOnLand, string text)
        {
            this.IsDeployedOnLand = isDeployedOnLand;
            this.Text             = text;
        }

        /**
         *
         * Metni değiştirir.
         *
         
         *
         */
        public void SetText(string text)
        {
            this.Text = text;
        }
    }
}