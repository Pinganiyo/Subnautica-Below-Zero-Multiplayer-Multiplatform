namespace Subnautica.Network.Models.Storage.Story.Components
{
    using MessagePack;

    [MessagePackObject]
    public class ShieldBaseComponent
    {
        /**
         *
         * IsEntered Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public bool IsFirstEntered { get; set; }

        /**
         *
         * Kalkan üssüne ilk giriş durumunu ayarlar.
         *
         
         *
         */
        public bool Enter()
        {
            if (this.IsFirstEntered)
            {
                return false;
            }

            this.IsFirstEntered = true;
            return true;
        }
    }
}