namespace Subnautica.Network.Models.Server
{
    using MessagePack;
    
    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;

    [MessagePackObject]
    public class NotificationAddedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.NotificationAdded;

        /**
         *
         * Grubu Barındırır.
         *
         
         *
         */
        [Key(5)]
        public NotificationManager.Group Group { get; set; }

        /**
         *
         * Key Barındırır.
         *
         
         *
         */
        [Key(6)]
        public string Key { get; set; }

        /**
         *
         * IsNotification Barındırır.
         *
         
         *
         */
        [Key(7)]
        public bool IsNotification { get; set; }

        /**
         *
         * IsAdded Barındırır.
         *
         
         *
         */
        [Key(8)]
        public bool IsAdded { get; set; }
        
        /**
         *
         * IsVisible Barındırır.
         *
         
         *
         */
        [Key(9)]
        public bool IsVisible { get; set; } = true;

        /**
         *
         * ColorIndex Barındırır.
         *
         
         *
         */
        [Key(10)]
        public sbyte ColorIndex { get; set; }
    }
}
