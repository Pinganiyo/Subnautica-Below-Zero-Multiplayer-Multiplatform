namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Game
    {
        /**
         *
         * GameQuitting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler Quitting;

        /**
         *
         * GameQuitting Olayı 
         *
         
         *
         */
        public static void OnQuitting() => Quitting.CustomInvoke();

        /**
         *
         * QuittingToMainMenu İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<QuittingToMainMenuEventArgs> QuittingToMainMenu;

        /**
         *
         * QuittingToMainMenu Olayı 
         *
         
         *
         */
        public static void OnQuittingToMainMenu(QuittingToMainMenuEventArgs ev) => QuittingToMainMenu.CustomInvoke(ev);

        /**
         *
         * SceneLoaded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SceneLoadedEventArgs> SceneLoaded;

        /**
         *
         * SceneLoaded Olayı 
         *
         
         *
         */
        public static void OnSceneLoaded(SceneLoadedEventArgs ev) => SceneLoaded.CustomInvoke(ev);

        /**
         *
         * MenuSaveCancelDeleteButtonClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MenuSaveCancelDeleteButtonClickingEventArgs> MenuSaveCancelDeleteButtonClicking;

        /**
         *
         * MenuSaveCancelDeleteButtonClicking Olayı 
         *
         
         *
         */
        public static void OnMenuSaveCancelDeleteButtonClicking(MenuSaveCancelDeleteButtonClickingEventArgs ev) => MenuSaveCancelDeleteButtonClicking.CustomInvoke(ev);

        /**
         *
         * MenuSaveDeleteButtonClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MenuSaveDeleteButtonClickingEventArgs> MenuSaveDeleteButtonClicking;

        /**
         *
         * MenuSaveDeleteButtonClicking Olayı 
         *
         
         *
         */
        public static void OnMenuSaveDeleteButtonClicking(MenuSaveDeleteButtonClickingEventArgs ev) => MenuSaveDeleteButtonClicking.CustomInvoke(ev);

        /**
         *
         * MenuSaveLoadButtonClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MenuSaveLoadButtonClickingEventArgs> MenuSaveLoadButtonClicking;

        /**
         *
         * MenuSaveLoadButtonClicking Olayı 
         *
         
         *
         */
        public static void OnMenuSaveLoadButtonClicking(MenuSaveLoadButtonClickingEventArgs ev) => MenuSaveLoadButtonClicking.CustomInvoke(ev);

        /**
         *
         * MenuSaveUpdateLoadedButtonState İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MenuSaveUpdateLoadedButtonStateEventArgs> MenuSaveUpdateLoadedButtonState;

        /**
         *
         * MenuSaveUpdateLoadedButtonState Olayı 
         *
         
         *
         */
        public static void OnMenuSaveUpdateLoadedButtonState(MenuSaveUpdateLoadedButtonStateEventArgs ev) => MenuSaveUpdateLoadedButtonState.CustomInvoke(ev);

        /**
         *
         * InGameMenuClosed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<InGameMenuClosedEventArgs> InGameMenuClosed;

        /**
         *
         * InGameMenuClosed Olayı 
         *
         
         *
         */
        public static void OnInGameMenuClosed(InGameMenuClosedEventArgs ev) => InGameMenuClosed.CustomInvoke(ev);
        
        /**
         *
         * InGameMenuClosing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<InGameMenuClosingEventArgs> InGameMenuClosing;

        /**
         *
         * InGameMenuClosing Olayı 
         *
         
         *
         */
        public static void OnInGameMenuClosing(InGameMenuClosingEventArgs ev) => InGameMenuClosing.CustomInvoke(ev);

        /**
         *
         * InGameMenuOpened İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<InGameMenuOpenedEventArgs> InGameMenuOpened;

        /**
         *
         * InGameMenuOpened Olayı 
         *
         
         *
         */
        public static void OnInGameMenuOpened(InGameMenuOpenedEventArgs ev) => InGameMenuOpened.CustomInvoke(ev);

        /**
         *
         * InGameMenuOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<InGameMenuOpeningEventArgs> InGameMenuOpening;

        /**
         *
         * InGameMenuOpening Olayı 
         *
         
         *
         */
        public static void OnInGameMenuOpening(InGameMenuOpeningEventArgs ev) => InGameMenuOpening.CustomInvoke(ev);

        /**
         *
         * InGameMenuSaveGame İşleyicisi
         *
         */
        public static event SubnauticaPluginEventHandler<InGameMenuSaveGameEventArgs> InGameMenuSaveGame;

        /**
         *
         * InGameMenuSaveGame Olayı 
         *
         */
        public static void OnInGameMenuSaveGame(InGameMenuSaveGameEventArgs ev) => InGameMenuSaveGame.CustomInvoke(ev);

        /**
         *
         * SettingsRunInBackgroundChanging İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SettingsRunInBackgroundChangingEventArgs> SettingsRunInBackgroundChanging;

        /**
         *
         * SettingsRunInBackgroundChanging Olayı 
         *
         
         *
         */
        public static void OnSettingsRunInBackgroundChanging(SettingsRunInBackgroundChangingEventArgs ev) => SettingsRunInBackgroundChanging.CustomInvoke(ev);

        /**
         *
         * SettingsPdaGamePauseChanging İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SettingsPdaGamePauseChangingEventArgs> SettingsPdaGamePauseChanging;

        /**
         *
         * SettingsPdaGamePauseChanging Olayı 
         *
         
         *
         */
        public static void OnSettingsPdaGamePauseChanging(SettingsPdaGamePauseChangingEventArgs ev) => SettingsPdaGamePauseChanging.CustomInvoke(ev);

        /**
         *
         * WorldLoading İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<WorldLoadingEventArgs> WorldLoading;

        /**
         *
         * WorldLoading Olayı 
         *
         
         *
         */
        public static void OnWorldLoading(WorldLoadingEventArgs ev) => WorldLoading.CustomInvoke(ev);


        /**
         *
         * WorldLoaded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<WorldLoadedEventArgs> WorldLoaded;

        /**
         *
         * WorldLoaded Olayı 
         *
         
         *
         */
        public static void OnWorldLoaded(WorldLoadedEventArgs ev) => WorldLoaded.CustomInvoke(ev);

        /**
         *
         * ScreenshotsRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ScreenshotsRemovedEventArgs> ScreenshotsRemoved;

        /**
         *
         * ScreenshotsRemoved Olayı 
         *
         
         *
         */
        public static void OnScreenshotsRemoved(ScreenshotsRemovedEventArgs ev) => ScreenshotsRemoved.CustomInvoke(ev);

        /**
         *
         * PowerSourceRemoving İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PowerSourceRemovingEventArgs> PowerSourceRemoving;

        /**
         *
         * PowerSourceRemoving Olayı 
         *
         
         *
         */
        public static void OnPowerSourceRemoving(PowerSourceRemovingEventArgs ev) => PowerSourceRemoving.CustomInvoke(ev);

        /**
         *
         * PowerSourceAdding İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PowerSourceAddingEventArgs> PowerSourceAdding;

        /**
         *
         * PowerSourceAdding Olayı 
         *
         
         *
         */
        public static void OnPowerSourceAdding(PowerSourceAddingEventArgs ev) => PowerSourceAdding.CustomInvoke(ev);

        /**
         *
         * IntroChecking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<IntroCheckingEventArgs> IntroChecking;

        /**
         *
         * IntroChecking Olayı 
         *
         
         *
         */
        public static void OnIntroChecking(IntroCheckingEventArgs ev) => IntroChecking.CustomInvoke(ev);

        /**
         *
         * LifepodInterpolation İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LifepodInterpolationEventArgs> LifepodInterpolation;

        /**
         *
         * LifepodInterpolation Olayı 
         *
         
         *
         */
        public static void OnLifepodInterpolation(LifepodInterpolationEventArgs ev) => LifepodInterpolation.CustomInvoke(ev);

        /**
         *
         * LifepodZoneCheck İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LifepodZoneCheckEventArgs> LifepodZoneCheck;

        /**
         *
         * LifepodZoneCheck Olayı 
         *
         
         *
         */
        public static void OnLifepodZoneCheck(LifepodZoneCheckEventArgs ev) => LifepodZoneCheck.CustomInvoke(ev);

        /**
         *
         * LifepodZoneSelecting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LifepodZoneSelectingEventArgs> LifepodZoneSelecting;

        /**
         *
         * LifepodZoneSelecting Olayı 
         *
         
         *
         */
        public static void OnLifepodZoneSelecting(LifepodZoneSelectingEventArgs ev) => LifepodZoneSelecting.CustomInvoke(ev);

        /**
         *
         * SubNameInputSelecting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SubNameInputSelectingEventArgs> SubNameInputSelecting;

        /**
         *
         * SubNameInputSelecting Olayı 
         *
         
         *
         */
        public static void OnSubNameInputSelecting(SubNameInputSelectingEventArgs ev) => SubNameInputSelecting.CustomInvoke(ev);

        /**
         *
         * SubNameInputDeselected İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SubNameInputDeselectedEventArgs> SubNameInputDeselected;

        /**
         *
         * SubNameInputDeselected Olayı 
         *
         
         *
         */
        public static void OnSubNameInputDeselected(SubNameInputDeselectedEventArgs ev) => SubNameInputDeselected.CustomInvoke(ev);

        /**
         *
         * EntityDistributionLoaded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler EntityDistributionLoaded;

        /**
         *
         * EntityDistributionLoaded Olayı 
         *
         
         *
         */
        public static void OnEntityDistributionLoaded() => EntityDistributionLoaded.CustomInvoke();
    }
}
