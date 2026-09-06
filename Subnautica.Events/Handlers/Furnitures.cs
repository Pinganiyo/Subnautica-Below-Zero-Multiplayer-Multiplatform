namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Furnitures
    {
        /**
         *
         * ToiletSwitchToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ToiletSwitchToggleEventArgs> ToiletSwitchToggle;

        /**
         *
         * ToiletSwitchToggle Olayı 
         *
         
         *
         */
        public static void OnToiletSwitchToggle(ToiletSwitchToggleEventArgs ev) => ToiletSwitchToggle.CustomInvoke(ev);

        /**
         *
         * EmmanuelPendulumSwitchToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EmmanuelPendulumSwitchToggleEventArgs> EmmanuelPendulumSwitchToggle;

        /**
         *
         * EmmanuelPendulumSwitchToggle Olayı 
         *
         
         *
         */
        public static void OnEmmanuelPendulumSwitchToggle(EmmanuelPendulumSwitchToggleEventArgs ev) => EmmanuelPendulumSwitchToggle.CustomInvoke(ev);

        /**
         *
         * AromatherapyLampSwitchToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<AromatherapyLampSwitchToggleEventArgs> AromatherapyLampSwitchToggle;

        /**
         *
         * AromatherapyLampSwitchToggle Olayı 
         *
         
         *
         */
        public static void OnAromatherapyLampSwitchToggle(AromatherapyLampSwitchToggleEventArgs ev) => AromatherapyLampSwitchToggle.CustomInvoke(ev);

        /**
         *
         * SmallStoveSwitchToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SmallStoveSwitchToggleEventArgs> SmallStoveSwitchToggle;

        /**
         *
         * SmallStoveSwitchToggle Olayı 
         *
         
         *
         */
        public static void OnSmallStoveSwitchToggle(SmallStoveSwitchToggleEventArgs ev) => SmallStoveSwitchToggle.CustomInvoke(ev);

        /**
         *
         * SinkSwitchToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SinkSwitchToggleEventArgs> SinkSwitchToggle;

        /**
         *
         * SinkSwitchToggle Olayı 
         *
         
         *
         */
        public static void OnSinkSwitchToggle(SinkSwitchToggleEventArgs ev) => SinkSwitchToggle.CustomInvoke(ev);

        /**
         *
         * ShowerSwitchToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ShowerSwitchToggleEventArgs> ShowerSwitchToggle;

        /**
         *
         * ShowerSwitchToggle Olayı 
         *
         
         *
         */
        public static void OnShowerSwitchToggle(ShowerSwitchToggleEventArgs ev) => ShowerSwitchToggle.CustomInvoke(ev);

        /**
         *
         * SnowmanDestroying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SnowmanDestroyingEventArgs> SnowmanDestroying;

        /**
         *
         * SnowmanDestroying Olayı 
         *
         
         *
         */
        public static void OnSnowmanDestroying(SnowmanDestroyingEventArgs ev) => SnowmanDestroying.CustomInvoke(ev);

        /**
         *
         * SignDataChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SignDataChangedEventArgs> SignDataChanged;

        /**
         *
         * SignDataChanged Olayı 
         *
         
         *
         */
        public static void OnSignDataChanged(SignDataChangedEventArgs ev) => SignDataChanged.CustomInvoke(ev);

        /**
         *
         * JukeboxUsed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<JukeboxUsedEventArgs> JukeboxUsed;

        /**
         *
         * JukeboxUsed Olayı 
         *
         
         *
         */
        public static void OnJukeboxUsed(JukeboxUsedEventArgs ev) => JukeboxUsed.CustomInvoke(ev);

        /**
         *
         * PictureFrameImageSelecting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PictureFrameImageSelectingEventArgs> PictureFrameImageSelecting;

        /**
         *
         * PictureFrameImageSelecting Olayı 
         *
         
         *
         */
        public static void OnPictureFrameImageSelecting(PictureFrameImageSelectingEventArgs ev) => PictureFrameImageSelecting.CustomInvoke(ev);

        /**
         *
         * BedIsCanSleepChecking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BedIsCanSleepCheckingEventArgs> BedIsCanSleepChecking;

        /**
         *
         * BedIsCanSleepChecking Olayı 
         *
         
         *
         */
        public static void OnBedIsCanSleepChecking(BedIsCanSleepCheckingEventArgs ev) => BedIsCanSleepChecking.CustomInvoke(ev);

        /**
         *
         * BedEnterInUseMode İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BedEnterInUseModeEventArgs> BedEnterInUseMode;

        /**
         *
         * BedEnterInUseMode Olayı 
         *
         
         *
         */
        public static void OnBedEnterInUseMode(BedEnterInUseModeEventArgs ev) => BedEnterInUseMode.CustomInvoke(ev);

        /**
         *
         * AquariumDataChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<AquariumDataChangedEventArgs> AquariumDataChanged;

        /**
         *
         * AquariumDataChanged Olayı 
         *
         
         *
         */
        public static void OnAquariumDataChanged(AquariumDataChangedEventArgs ev) => AquariumDataChanged.CustomInvoke(ev);

        /**
         *
         * CrafterOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrafterOpeningEventArgs> CrafterOpening;

        /**
         *
         * CrafterOpening Olayı 
         *
         
         *
         */
        public static void OnCrafterOpening(CrafterOpeningEventArgs ev) => CrafterOpening.CustomInvoke(ev);

        /**
         *
         * CrafterClosed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrafterClosedEventArgs> CrafterClosed;

        /**
         *
         * CrafterClosed Olayı 
         *
         
         *
         */
        public static void OnCrafterClosed(CrafterClosedEventArgs ev) => CrafterClosed.CustomInvoke(ev);

        /**
         *
         * CrafterEnded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrafterEndedEventArgs> CrafterEnded;

        /**
         *
         * CrafterEnded Olayı 
         *
         
         *
         */
        public static void OnCrafterEnded(CrafterEndedEventArgs ev) => CrafterEnded.CustomInvoke(ev);

        /**
         *
         * CrafterBegin İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrafterBeginEventArgs> CrafterBegin;

        /**
         *
         * CrafterBegin Olayı 
         *
         
         *
         */
        public static void OnCrafterBegin(CrafterBeginEventArgs ev) => CrafterBegin.CustomInvoke(ev);

        /**
         *
         * CrafterItemPickup İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrafterItemPickupEventArgs> CrafterItemPickup;

        /**
         *
         * CrafterItemPickup Olayı 
         *
         
         *
         */
        public static void OnCrafterItemPickup(CrafterItemPickupEventArgs ev) => CrafterItemPickup.CustomInvoke(ev);

        /**
         *
         * BenchStandup İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BenchStandupEventArgs> BenchStandup;

        /**
         *
         * BenchStandup Olayı 
         *
         
         *
         */
        public static void OnBenchStandup(BenchStandupEventArgs ev) => BenchStandup.CustomInvoke(ev);

        /**
         *
         * BenchSitdown İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BenchSitdownEventArgs> BenchSitdown;

        /**
         *
         * BenchSitdown Olayı 
         *
         
         *
         */
        public static void OnBenchSitdown(BenchSitdownEventArgs ev) => BenchSitdown.CustomInvoke(ev);

        /**
         *
         * SignSelect İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SignSelectEventArgs> SignSelect;

        /**
         *
         * SignSelect Olayı 
         *
         
         *
         */
        public static void OnSignSelect(SignSelectEventArgs ev) => SignSelect.CustomInvoke(ev);

        /**
         *
         * SignDeselect İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SignDeselectEventArgs> SignDeselect;

        /**
         *
         * SignDeselect Olayı 
         *
         
         *
         */
        public static void OnSignDeselect(SignDeselectEventArgs ev) => SignDeselect.CustomInvoke(ev);

        /**
         *
         * PictureFrameOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PictureFrameOpeningEventArgs> PictureFrameOpening;

        /**
         *
         * PictureFrameOpening Olayı 
         *
         
         *
         */
        public static void OnPictureFrameOpening(PictureFrameOpeningEventArgs ev) => PictureFrameOpening.CustomInvoke(ev);

        /**
         *
         * ChargerOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ChargerOpeningEventArgs> ChargerOpening;

        /**
         *
         * ChargerOpening Olayı 
         *
         
         *
         */
        public static void OnChargerOpening(ChargerOpeningEventArgs ev) => ChargerOpening.CustomInvoke(ev);

        /**
         *
         * HoverpadHoverbikeSpawning İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<HoverpadHoverbikeSpawningEventArgs> HoverpadHoverbikeSpawning;

        /**
         *
         * HoverpadHoverbikeSpawning Olayı 
         *
         
         *
         */
        public static void OnHoverpadHoverbikeSpawning(HoverpadHoverbikeSpawningEventArgs ev) => HoverpadHoverbikeSpawning.CustomInvoke(ev);

        /**
         *
         * RecyclotronRecycle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<RecyclotronRecycleEventArgs> RecyclotronRecycle;

        /**
         *
         * RecyclotronRecycle Olayı 
         *
         
         *
         */
        public static void OnRecyclotronRecycle(RecyclotronRecycleEventArgs ev) => RecyclotronRecycle.CustomInvoke(ev);

        /**
         *
         * FiltrationMachineOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<FiltrationMachineOpeningEventArgs> FiltrationMachineOpening;

        /**
         *
         * FiltrationMachineOpening Olayı 
         *
         
         *
         */
        public static void OnFiltrationMachineOpening(FiltrationMachineOpeningEventArgs ev) => FiltrationMachineOpening.CustomInvoke(ev);

        /**
         *
         * PlanterItemAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlanterItemAddedEventArgs> PlanterItemAdded;

        /**
         *
         * PlanterItemAdded Olayı 
         *
         
         *
         */
        public static void OnPlanterItemAdded(PlanterItemAddedEventArgs ev) => PlanterItemAdded.CustomInvoke(ev);

        /**
         *
         * PlanterGrowned İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlanterGrownedEventArgs> PlanterGrowned;

        /**
         *
         * PlanterGrowned Olayı 
         *
         
         *
         */
        public static void OnPlanterGrowned(PlanterGrownedEventArgs ev) => PlanterGrowned.CustomInvoke(ev);

        /**
         *
         * PlanterProgressCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlanterProgressCompletedEventArgs> PlanterProgressCompleted;

        /**
         *
         * PlanterProgressCompleted Olayı 
         *
         
         *
         */
        public static void OnPlanterProgressCompleted(PlanterProgressCompletedEventArgs ev) => PlanterProgressCompleted.CustomInvoke(ev);

        /**
         *
         * BedExitInUseMode İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BedExitInUseModeEventArgs> BedExitInUseMode;

        /**
         *
         * BedExitInUseMode Olayı 
         *
         
         *
         */
        public static void OnBedExitInUseMode(BedExitInUseModeEventArgs ev) => BedExitInUseMode.CustomInvoke(ev);

        /**
         *
         * BulkheadOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BulkheadOpeningEventArgs> BulkheadOpening;

        /**
         *
         * BulkheadOpening Olayı 
         *
         
         *
         */
        public static void OnBulkheadOpening(BulkheadOpeningEventArgs ev) => BulkheadOpening.CustomInvoke(ev);

        /**
         *
         * BulkheadClosing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BulkheadClosingEventArgs> BulkheadClosing;

        /**
         *
         * BulkheadClosing Olayı 
         *
         
         *
         */
        public static void OnBulkheadClosing(BulkheadClosingEventArgs ev) => BulkheadClosing.CustomInvoke(ev);

        /**
         *
         * BaseControlRoomMinimapUsing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseControlRoomMinimapUsingEventArgs> BaseControlRoomMinimapUsing;

        /**
         *
         * BaseControlRoomMinimapUsing Olayı 
         *
         
         *
         */
        public static void OnBaseControlRoomMinimapUsing(BaseControlRoomMinimapUsingEventArgs ev) => BaseControlRoomMinimapUsing.CustomInvoke(ev);

        /**
         *
         * BaseControlRoomMinimapExiting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseControlRoomMinimapExitingEventArgs> BaseControlRoomMinimapExiting;

        /**
         *
         * BaseControlRoomMinimapExiting Olayı 
         *
         
         *
         */
        public static void OnBaseControlRoomMinimapExiting(BaseControlRoomMinimapExitingEventArgs ev) => BaseControlRoomMinimapExiting.CustomInvoke(ev);

        /**
         *
         * BaseControlRoomCellPowerChanging İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseControlRoomCellPowerChangingEventArgs> BaseControlRoomCellPowerChanging;

        /**
         *
         * BaseControlRoomCellPowerChanging Olayı 
         *
         
         *
         */
        public static void OnBaseControlRoomCellPowerChanging(BaseControlRoomCellPowerChangingEventArgs ev) => BaseControlRoomCellPowerChanging.CustomInvoke(ev);

        /**
         *
         * BaseControlRoomMinimapMoving İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseControlRoomMinimapMovingEventArgs> BaseControlRoomMinimapMoving;

        /**
         *
         * BaseControlRoomMinimapMoving Olayı 
         *
         
         *
         */
        public static void OnBaseControlRoomMinimapMoving(BaseControlRoomMinimapMovingEventArgs ev) => BaseControlRoomMinimapMoving.CustomInvoke(ev);

        /**
         *
         * HoverpadDocking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<HoverpadDockingEventArgs> HoverpadDocking;

        /**
         *
         * HoverpadDocking Olayı 
         *
         
         *
         */
        public static void OnHoverpadDocking(HoverpadDockingEventArgs ev) => HoverpadDocking.CustomInvoke(ev);

        /**
         *
         * HoverpadUnDocking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<HoverpadUnDockingEventArgs> HoverpadUnDocking;

        /**
         *
         * HoverpadUnDocking Olayı 
         *
         
         *
         */
        public static void OnHoverpadUnDocking(HoverpadUnDockingEventArgs ev) => HoverpadUnDocking.CustomInvoke(ev);

        /**
         *
         * HoverpadShowroomTriggering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<HoverpadShowroomTriggeringEventArgs> HoverpadShowroomTriggering;

        /**
         *
         * HoverpadShowroomTriggering Olayı 
         *
         
         *
         */
        public static void OnHoverpadShowroomTriggering(HoverpadShowroomTriggeringEventArgs ev) => HoverpadShowroomTriggering.CustomInvoke(ev);

        /**
         *
         * SpotLightInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SpotLightInitializedEventArgs> SpotLightInitialized;

        /**
         *
         * SpotLightInitialized Olayı 
         *
         
         *
         */
        public static void OnSpotLightInitialized(SpotLightInitializedEventArgs ev) => SpotLightInitialized.CustomInvoke(ev);

        /**
         *
         * TechLightInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TechLightInitializedEventArgs> TechLightInitialized;

        /**
         *
         * TechLightInitialized Olayı 
         *
         
         *
         */
        public static void OnTechLightInitialized(TechLightInitializedEventArgs ev) => TechLightInitialized.CustomInvoke(ev);

        /**
         *
         * BaseMapRoomScanStopping İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMapRoomScanStoppingEventArgs> BaseMapRoomScanStopping;

        /**
         *
         * BaseMapRoomScanStopping Olayı 
         *
         
         *
         */
        public static void OnBaseMapRoomScanStopping(BaseMapRoomScanStoppingEventArgs ev) => BaseMapRoomScanStopping.CustomInvoke(ev);

        /**
         *
         * BaseMapRoomScanStarting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMapRoomScanStartingEventArgs> BaseMapRoomScanStarting;

        /**
         *
         * BaseMapRoomScanStarting Olayı 
         *
         
         *
         */
        public static void OnBaseMapRoomScanStarting(BaseMapRoomScanStartingEventArgs ev) => BaseMapRoomScanStarting.CustomInvoke(ev);

        /**
         *
         * MapRoomCameraChanging İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MapRoomCameraChangingEventArgs> BaseMapRoomCameraChanging;

        /**
         *
         * MapRoomCameraChanging Olayı 
         *
         
         *
         */
        public static void OnBaseMapRoomCameraChanging(MapRoomCameraChangingEventArgs ev) => BaseMapRoomCameraChanging.CustomInvoke(ev);

        /**
         *
         * MapRoomResourceDiscovering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMapRoomResourceDiscoveringEventArgs> BaseMapRoomResourceDiscovering;

        /**
         *
         * MapRoomResourceDiscovering Olayı 
         *
         
         *
         */
        public static void OnBaseMapRoomResourceDiscovering(BaseMapRoomResourceDiscoveringEventArgs ev) => BaseMapRoomResourceDiscovering.CustomInvoke(ev);

        /**
         *
         * BaseMapRoomInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMapRoomInitializedEventArgs> BaseMapRoomInitialized;

        /**
         *
         * BaseMapRoomInitialized Olayı 
         *
         
         *
         */
        public static void OnBaseMapRoomInitialized(BaseMapRoomInitializedEventArgs ev) => BaseMapRoomInitialized.CustomInvoke(ev);

        /**
         *
         * BaseMoonpoolExpansionUndockingTimelineCompleting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMoonpoolExpansionUndockingTimelineCompletingEventArgs> BaseMoonpoolExpansionUndockingTimelineCompleting;

        /**
         *
         * BaseMoonpoolExpansionUndockingTimelineCompleting Olayı 
         *
         
         *
         */
        public static void OnBaseMoonpoolExpansionUndockingTimelineCompleting(BaseMoonpoolExpansionUndockingTimelineCompletingEventArgs ev) => BaseMoonpoolExpansionUndockingTimelineCompleting.CustomInvoke(ev);

        /**
         *
         * BaseMoonpoolExpansionDockingTimelineCompleting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMoonpoolExpansionDockingTimelineCompletingEventArgs> BaseMoonpoolExpansionDockingTimelineCompleting;

        /**
         *
         * BaseMoonpoolExpansionDockingTimelineCompleting Olayı 
         *
         
         *
         */
        public static void OnBaseMoonpoolExpansionDockingTimelineCompleting(BaseMoonpoolExpansionDockingTimelineCompletingEventArgs ev) => BaseMoonpoolExpansionDockingTimelineCompleting.CustomInvoke(ev);

        /**
         *
         * BaseMoonpoolExpansionDockTail İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMoonpoolExpansionDockTailEventArgs> BaseMoonpoolExpansionDockTail;

        /**
         *
         * BaseMoonpoolExpansionDockTail Olayı 
         *
         
         *
         */
        public static void OnBaseMoonpoolExpansionDockTail(BaseMoonpoolExpansionDockTailEventArgs ev) => BaseMoonpoolExpansionDockTail.CustomInvoke(ev);

        /**
         *
         * BaseMoonpoolExpansionUndockTail İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseMoonpoolExpansionUndockTailEventArgs> BaseMoonpoolExpansionUndockTail;

        /**
         *
         * BaseMoonpoolExpansionUndockTail Olayı 
         *
         
         *
         */
        public static void OnBaseMoonpoolExpansionUndockTail(BaseMoonpoolExpansionUndockTailEventArgs ev) => BaseMoonpoolExpansionUndockTail.CustomInvoke(ev);
    }
}