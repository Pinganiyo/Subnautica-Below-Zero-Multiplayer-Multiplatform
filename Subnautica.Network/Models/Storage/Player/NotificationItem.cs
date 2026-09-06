namespace Subnautica.Network.Models.Storage.Player
{
    using MessagePack;

    [MessagePackObject]
    public class NotificationItem
    {
        /**
         *
         * Grubu Barındırır.
         *
         
         *
         */
        [Key(0)]
        public NotificationManager.Group Group { get; set; }

        /**
         *
         * Key Barındırır.
         *
         
         *
         */
        [Key(1)]
        public string Key { get; set; }

        /**
         *
         * IsViewed Barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsViewed { get; set; }

        /**
         *
         * IsPing Barındırır.
         *
         
         *
         */
        [Key(3)]
        public bool IsPing { get; set; }

        /**
         *
         * IsVisibility Barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsVisible { get; set; }

        /**
         *
         * ColorIndex Barındırır.
         *
         
         *
         */
        [Key(5)]
        public sbyte ColorIndex { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public NotificationItem()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public NotificationItem(NotificationManager.Group group, string key, bool isViewed, bool isPing, bool isVisible, sbyte colorIndex)
        {
            this.Group      = group;
            this.Key        = key;
            this.IsViewed   = isViewed;
            this.IsPing     = isPing;
            this.IsVisible  = isVisible;
            this.ColorIndex = colorIndex;
        }
    }
}

