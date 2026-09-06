namespace Subnautica.Network.Models.Metadata
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class Jukebox : MetadataComponent
    {
        /**
         *
         * CurrentPlayingTrack Değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public string CurrentPlayingTrack { get; set; }

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
         * IsStoped değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public bool IsStoped { get; set; }

        /**
         *
         * IsNext değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public bool IsNext { get; set; }

        /**
         *
         * IsPrevious değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public bool IsPrevious { get; set; }

        /**
         *
         * RepeatMode değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public global::Jukebox.Repeat RepeatMode { get; set; }

        /**
         *
         * Shuffle değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public bool IsShuffled { get; set; }

        /**
         *
         * Position değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public float Position { get; set; }

        /**
         *
         * Length değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public uint Length { get; set; }

        /**
         *
         * Volume değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public float Volume { get; set; }
    }
}
