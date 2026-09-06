namespace Subnautica.Network.Models.Storage.Story
{
    using System;
    using System.Collections.Generic;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Storage.Story.Components;
    using Subnautica.Network.Models.Storage.Story.StoryGoals;

    [MessagePackObject]
    [Serializable]
    public class Story
    {
        /**
         *
         * StoryGoalTrackers değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public HashSet<ZeroStoryGoal> CompletedGoals { get; set; } = new HashSet<ZeroStoryGoal>();

        /**
         *
         * Signals değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public HashSet<ZeroStorySignal> Signals { get; set; } = new HashSet<ZeroStorySignal>();

        /**
         *
         * CompletedCinematics değerini barındırır.
         *
         
         *
         */
        [Key(2)]
        public List<StoryCinematicType> CompletedCinematics { get; set; } = new List<StoryCinematicType>();

        /**
         *
         * CompletedCinematics değerini barındırır.
         *
         
         *
         */
        [Key(3)]
        public List<string> CompletedCalls { get; set; } = new List<string>();

        /**
         *
         * IncomingCallGoalKey değerini barındırır.
         *
         
         *
         */
        [Key(4)]
        public string IncomingCallGoalKey { get; set; } = null;

        /**
         *
         * Bridge Değerini barındırır.
         *
         
         *
         */
        [Key(5)]
        public GlacialBasinBridgeComponent Bridge { get; set; } = new GlacialBasinBridgeComponent();

        /**
         *
         * CompletedTriggers Değerini barındırır.
         *
         
         *
         */
        [Key(6)]
        public HashSet<string> CompletedTriggers { get; set; } = new HashSet<string>();

        /**
         *
         * CustomDoorways değerini barındırır.
         *
         
         *
         */
        [Key(7)]
        public List<CustomDoorwayComponent> CustomDoorways { get; set; } = new List<CustomDoorwayComponent>();

        /**
         *
         * FrozenCreature Değerini barındırır.
         *
         
         *
         */
        [Key(8)]
        public FrozenCreatureComponent FrozenCreature { get; set; } = new FrozenCreatureComponent();

        /**
         *
         * FrozenCreature Değerini barındırır.
         *
         
         *
         */
        [Key(9)]
        public ShieldBaseComponent ShieldBase { get; set; } = new ShieldBaseComponent();
    }
}