namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Story
    {
        /**
         *
         * BridgeFluidClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BridgeFluidClickingEventArgs> BridgeFluidClicking;

        /**
         *
         * BridgeFluidClicking Olayı 
         *
         
         *
         */
        public static void OnBridgeFluidClicking(BridgeFluidClickingEventArgs ev) => BridgeFluidClicking.CustomInvoke(ev);

        /**
         *
         * BridgeTerminalClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BridgeTerminalClickingEventArgs> BridgeTerminalClicking;

        /**
         *
         * BridgeTerminalClicking Olayı 
         *
         
         *
         */
        public static void OnBridgeTerminalClicking(BridgeTerminalClickingEventArgs ev) => BridgeTerminalClicking.CustomInvoke(ev);

        /**
         *
         * BridgeInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BridgeInitializedEventArgs> BridgeInitialized;

        /**
         *
         * BridgeInitialized Olayı 
         *
         
         *
         */
        public static void OnBridgeInitialized(BridgeInitializedEventArgs ev) => BridgeInitialized.CustomInvoke(ev);

        /**
         *
         * RadioTowerTOMUsing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<RadioTowerTOMUsingEventArgs> RadioTowerTOMUsing;

        /**
         *
         * RadioTowerTOMUsing Olayı 
         *
         
         *
         */
        public static void OnRadioTowerTOMUsing(RadioTowerTOMUsingEventArgs ev) => RadioTowerTOMUsing.CustomInvoke(ev);

        /**
         *
         * StorySignalSpawning İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StorySignalSpawningEventArgs> StorySignalSpawning;

        /**
         *
         * StorySignalSpawning Olayı 
         *
         
         *
         */
        public static void OnStorySignalSpawning(StorySignalSpawningEventArgs ev) => StorySignalSpawning.CustomInvoke(ev);

        /**
         *
         * StoryGoalTriggering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StoryGoalTriggeringEventArgs> StoryGoalTriggering;

        /**
         *
         * StoryGoalTriggering Olayı 
         *
         
         *
         */
        public static void OnStoryGoalTriggering(StoryGoalTriggeringEventArgs ev) => StoryGoalTriggering.CustomInvoke(ev);

        /**
         *
         * CinematicTriggering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CinematicTriggeringEventArgs> CinematicTriggering;

        /**
         *
         * CinematicTriggering Olayı 
         *
         
         *
         */
        public static void OnCinematicTriggering(CinematicTriggeringEventArgs ev) => CinematicTriggering.CustomInvoke(ev);

        /**
         *
         * StoryCalling İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StoryCallingEventArgs> StoryCalling;

        /**
         *
         * StoryCalling Olayı 
         *
         
         *
         */
        public static void OnStoryCalling(StoryCallingEventArgs ev) => StoryCalling.CustomInvoke(ev);

        /**
         *
         * StoryHandClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StoryHandClickingEventArgs> StoryHandClicking;

        /**
         *
         * StoryHandClicking Olayı 
         *
         
         *
         */
        public static void OnStoryHandClicking(StoryHandClickingEventArgs ev) => StoryHandClicking.CustomInvoke(ev);

        /**
         *
         * StoryCinematicStarted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StoryCinematicStartedEventArgs> StoryCinematicStarted;

        /**
         *
         * StoryCinematicStarted Olayı 
         *
         
         *
         */
        public static void OnStoryCinematicStarted(StoryCinematicStartedEventArgs ev) => StoryCinematicStarted.CustomInvoke(ev);

        /**
         *
         * StoryCinematicCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StoryCinematicCompletedEventArgs> StoryCinematicCompleted;

        /**
         *
         * StoryCinematicCompleted Olayı 
         *
         
         *
         */
        public static void OnStoryCinematicCompleted(StoryCinematicCompletedEventArgs ev) => StoryCinematicCompleted.CustomInvoke(ev);

        /**
         *
         * MobileExtractorMachineInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler MobileExtractorMachineInitialized;

        /**
         *
         * MobileExtractorMachineInitialized Olayı 
         *
         
         *
         */
        public static void OnMobileExtractorMachineInitialized() => MobileExtractorMachineInitialized.CustomInvoke();

        /**
         *
         * MobileExtractorMachineSampleAdding İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MobileExtractorMachineSampleAddingEventArgs> MobileExtractorMachineSampleAdding;

        /**
         *
         * MobileExtractorMachineSampleAdding Olayı 
         *
         
         *
         */
        public static void OnMobileExtractorMachineSampleAdding(MobileExtractorMachineSampleAddingEventArgs ev) => MobileExtractorMachineSampleAdding.CustomInvoke(ev);

        /**
         *
         * MobileExtractorConsoleUsing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MobileExtractorConsoleUsingEventArgs> MobileExtractorConsoleUsing;

        /**
         *
         * MobileExtractorConsoleUsing Olayı 
         *
         
         *
         */
        public static void OnMobileExtractorConsoleUsing(MobileExtractorConsoleUsingEventArgs ev) => MobileExtractorConsoleUsing.CustomInvoke(ev);

        /**
         *
         * ShieldBaseEnterTriggering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ShieldBaseEnterTriggeringEventArgs> ShieldBaseEnterTriggering;

        /**
         *
         * ShieldBaseEnterTriggering Olayı 
         *
         
         *
         */
        public static void OnShieldBaseEnterTriggering(ShieldBaseEnterTriggeringEventArgs ev) => ShieldBaseEnterTriggering.CustomInvoke(ev);
    }
}