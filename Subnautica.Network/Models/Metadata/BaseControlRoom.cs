namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class BaseControlRoom : MetadataComponent
    {
        /**
         *
         * Name değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public string Name { get; set; }

        /**
         *
         * BaseColor değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public ZeroColor BaseColor { get; set; }

        /**
         *
         * StripeColor1 değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroColor StripeColor1 { get; set; }

        /**
         *
         * StripeColor2 değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public ZeroColor StripeColor2 { get; set; }

        /**
         *
         * NameColor değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public ZeroColor NameColor { get; set; }

        /**
         *
         * Minimap değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public BaseControlRoomMinimap Minimap { get; set; }

        /**
         *
         * IsNavigateOpening değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsNavigateOpening { get; set; }

        /**
         *
         * IsColorCustomizerOpening değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public bool IsColorCustomizerOpening { get; set; }

        /**
         *
         * IsColorCustomizerSave değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public bool IsColorCustomizerSave { get; set; }

        /**
         *
         * IsNavigationExiting değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public bool IsNavigationExiting { get; set; }
    }

    [MessagePackObject]
    public class BaseControlRoomMinimap
    {
        /**
         *
         * Position değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Cell değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public ZeroInt3 Cell { get; set; }

        /**
         *
         * IsPowered değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsPowered { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public BaseControlRoomMinimap()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public BaseControlRoomMinimap(ZeroVector3 position, ZeroInt3 cell, bool isPowered = false)
        {
            this.Position  = position;
            this.Cell      = cell;
            this.IsPowered = isPowered;
        }
    }
}
