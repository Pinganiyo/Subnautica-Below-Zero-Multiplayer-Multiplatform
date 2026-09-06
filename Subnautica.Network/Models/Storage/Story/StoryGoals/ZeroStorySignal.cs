namespace Subnautica.Network.Models.Storage.Story.StoryGoals
{
    using global::Story;

    using MessagePack;

    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class ZeroStorySignal
    {
        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        [Key(0)]
        public string UniqueId { get; set; }

        /**
         *
         * SignalType değeri
         *
         
         *
         */
        [Key(1)]
        public UnlockSignalData.SignalType SignalType { get; set; }

        /**
         *
         * TargetPosition değeri
         *
         
         *
         */
        [Key(2)]
        public ZeroVector3 TargetPosition { get; set; }

        /**
         *
         * TargetDescription değeri
         *
         
         *
         */
        [Key(3)]
        public string TargetDescription { get; set; }

        /**
         *
         * IsVisited değeri
         *
         
         *
         */
        [Key(4)]
        public bool IsVisited { get; set; }

        /**
         *
         * IsRemoved değeri
         *
         
         *
         */
        [Key(5)]
        public bool IsRemoved { get; set; }
    }
}
