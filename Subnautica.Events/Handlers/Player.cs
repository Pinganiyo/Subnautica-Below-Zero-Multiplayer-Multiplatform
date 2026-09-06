namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Player
    {
        /**
         *
         * Updated İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerUpdatedEventArgs> Updated;

        /**
         *
         * Updated Olayı 
         *
         
         *
         */
        public static void OnUpdated(PlayerUpdatedEventArgs ev) => Updated.CustomInvoke(ev);

        /**
         *
         * PlayerStatsUpdated İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerStatsUpdatedEventArgs> StatsUpdated;

        /**
         *
         * PlayerStatsUpdated Olayı 
         *
         
         *
         */
        public static void OnStatsUpdated(PlayerStatsUpdatedEventArgs ev) => StatsUpdated.CustomInvoke(ev);

        /**
         *
         * PlayerBaseEntered İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerBaseEnteredEventArgs> PlayerBaseEntered;

        /**
         *
         * PlayerBaseEntered Olayı 
         *
         
         *
         */
        public static void OnPlayerBaseEntered(PlayerBaseEnteredEventArgs ev) => PlayerBaseEntered.CustomInvoke(ev);

        /**
         *
         * PlayerBaseExited İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerBaseExitedEventArgs> PlayerBaseExited;

        /**
         *
         * PlayerBaseExited Olayı 
         *
         
         *
         */
        public static void OnPlayerBaseExited(PlayerBaseExitedEventArgs ev) => PlayerBaseExited.CustomInvoke(ev);

        /**
         *
         * ItemDrawed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ItemDrawedEventArgs> ItemDrawed;

        /**
         *
         * ItemDrawed Olayı 
         *
         
         *
         */
        public static void OnItemDrawed(ItemDrawedEventArgs ev) => ItemDrawed.CustomInvoke(ev);

        /**
         *
         * ItemActionStarted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ItemActionStartedEventArgs> ItemActionStarted;

        /**
         *
         * ItemActionStarted Olayı 
         *
         
         *
         */
        public static void OnItemActionStarted(ItemActionStartedEventArgs ev) => ItemActionStarted.CustomInvoke(ev);

        /**
         *
         * ItemFirstUseAnimationStoped İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ItemFirstUseAnimationStopedEventArgs> ItemFirstUseAnimationStoped;

        /**
         *
         * ItemFirstUseAnimationStoped Olayı 
         *
         
         *
         */
        public static void OnItemFirstUseAnimationStoped(ItemFirstUseAnimationStopedEventArgs ev) => ItemFirstUseAnimationStoped.CustomInvoke(ev);

        /**
         *
         * EntityScannerCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EntityScannerCompletedEventArgs> EntityScannerCompleted;

        /**
         *
         * EntityScannerCompleted Olayı 
         *
         
         *
         */
        public static void OnEntityScannerCompleted(EntityScannerCompletedEventArgs ev) => EntityScannerCompleted.CustomInvoke(ev);

        /**
         *
         * ItemPickedUp İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerItemPickedUpEventArgs> ItemPickedUp;

        /**
         *
         * ItemPickedUp Olayı 
         *
         
         *
         */
        public static void OnItemPickedUp(PlayerItemPickedUpEventArgs ev) => ItemPickedUp.CustomInvoke(ev);

        /**
         *
         * PlayerAnimationChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerAnimationChangedEventArgs> AnimationChanged;

        /**
         *
         * PlayerAnimationChanged Olayı 
         *
         
         *
         */
        public static void OnAnimationChanged(PlayerAnimationChangedEventArgs ev) => AnimationChanged.CustomInvoke(ev);

        /**
         *
         * PlayerItemDroping İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerItemDropingEventArgs> ItemDroping;

        /**
         *
         * PlayerItemDroping Olayı 
         *
         
         *
         */
        public static void OnItemDroping(PlayerItemDropingEventArgs ev) => ItemDroping.CustomInvoke(ev);

        /**
         *
         * SleepScreenStopingStarted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler SleepScreenStopingStarted;

        /**
         *
         * SleepScreenStopingStarted Olayı 
         *
         
         *
         */
        public static void OnSleepScreenStopingStarted() => SleepScreenStopingStarted.CustomInvoke();

        /**
         *
         * SleepScreenStartingCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler SleepScreenStartingCompleted;

        /**
         *
         * SleepScreenStartingCompleted Olayı 
         *
         
         *
         */
        public static void OnSleepScreenStartingCompleted() => SleepScreenStartingCompleted.CustomInvoke();

        /**
         *
         * UseableDiveHatchClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<UseableDiveHatchClickingEventArgs> UseableDiveHatchClicking;

        /**
         *
         * UseableDiveHatchClicking Olayı 
         *
         
         *
         */
        public static void OnUseableDiveHatchClicking(UseableDiveHatchClickingEventArgs ev) => UseableDiveHatchClicking.CustomInvoke(ev);

        /**
         *
         * EnteredInterior İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerEnteredInteriorEventArgs> EnteredInterior;

        /**
         *
         * EnteredInterior Olayı 
         *
         
         *
         */
        public static void OnEnteredInterior(PlayerEnteredInteriorEventArgs ev) => EnteredInterior.CustomInvoke(ev);

        /**
         *
         * ExitedInterior İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerExitedInteriorEventArgs> ExitedInterior;

        /**
         *
         * ExitedInterior Olayı 
         *
         
         *
         */
        public static void OnExitedInterior(PlayerExitedInteriorEventArgs ev) => ExitedInterior.CustomInvoke(ev);
        
        /**
         *
         * Climbing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerClimbingEventArgs> Climbing;

        /**
         *
         * Climbing Olayı 
         *
         
         *
         */
        public static void OnClimbing(PlayerClimbingEventArgs ev) => Climbing.CustomInvoke(ev);
        
        /**
         *
         * Dead İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerDeadEventArgs> Dead;

        /**
         *
         * Dead Olayı 
         *
         
         *
         */
        public static void OnDead(PlayerDeadEventArgs ev) => Dead.CustomInvoke(ev);
        
        /**
         *
         * OnSpawned İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler Spawned;

        /**
         *
         * OnSpawned Olayı 
         *
         
         *
         */
        public static void OnSpawned() => Spawned.CustomInvoke();
        
        /**
         *
         * EnergyMixinClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EnergyMixinClickingEventArgs> EnergyMixinClicking;

        /**
         *
         * EnergyMixinClicking Olayı 
         *
         
         *
         */
        public static void OnEnergyMixinClicking(EnergyMixinClickingEventArgs ev) => EnergyMixinClicking.CustomInvoke(ev);
        
        /**
         *
         * EnergyMixinSelecting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EnergyMixinSelectingEventArgs> EnergyMixinSelecting;

        /**
         *
         * EnergyMixinSelecting Olayı 
         *
         
         *
         */
        public static void OnEnergyMixinSelecting(EnergyMixinSelectingEventArgs ev) => EnergyMixinSelecting.CustomInvoke(ev);

        
        /**
         *
         * EnergyMixinClosed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EnergyMixinClosedEventArgs> EnergyMixinClosed;

        /**
         *
         * EnergyMixinClosed Olayı 
         *
         
         *
         */
        public static void OnEnergyMixinClosed(EnergyMixinClosedEventArgs ev) => EnergyMixinClosed.CustomInvoke(ev);

        /**
         *
         * BreakableResourceBreaking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BreakableResourceBreakingEventArgs> BreakableResourceBreaking;

        /**
         *
         * BreakableResourceBreaking Olayı 
         *
         
         *
         */
        public static void OnBreakableResourceBreaking(BreakableResourceBreakingEventArgs ev) => BreakableResourceBreaking.CustomInvoke(ev);

        /**
         *
         * PingVisibilityChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerPingVisibilityChangedEventArgs> PingVisibilityChanged;

        /**
         *
         * PingVisibilityChanged Olayı 
         *
         
         *
         */
        public static void OnPingVisibilityChanged(PlayerPingVisibilityChangedEventArgs ev) => PingVisibilityChanged.CustomInvoke(ev);

        /**
         *
         * PingColorChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerPingColorChangedEventArgs> PingColorChanged;

        /**
         *
         * PingColorChanged Olayı 
         *
         
         *
         */
        public static void OnPingColorChanged(PlayerPingColorChangedEventArgs ev) => PingColorChanged.CustomInvoke(ev);
        
        /**
         *
         * PrecursorTeleporterUsed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler PrecursorTeleporterUsed;

        /**
         *
         * PrecursorTeleporterUsed Olayı 
         *
         
         *
         */
        public static void OnPrecursorTeleporterUsed() => PrecursorTeleporterUsed.CustomInvoke();
        
        /**
         *
         * PrecursorTeleportationCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler PrecursorTeleportationCompleted;

        /**
         *
         * PrecursorTeleportationCompleted Olayı 
         *
         
         *
         */
        public static void OnPrecursorTeleportationCompleted() => PrecursorTeleportationCompleted.CustomInvoke();
        
        /**
         *
         * ToolBatteryEnergyChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ToolBatteryEnergyChangedEventArgs> ToolBatteryEnergyChanged;

        /**
         *
         * ToolBatteryEnergyChanged Olayı 
         *
         
         *
         */
        public static void OnToolBatteryEnergyChanged(ToolBatteryEnergyChangedEventArgs ev) => ToolBatteryEnergyChanged.CustomInvoke(ev);
        
        /**
         *
         * PlayerUsingCommand İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerUsingCommandEventArgs> PlayerUsingCommand;

        /**
         *
         * PlayerUsingCommand Olayı 
         *
         
         *
         */
        public static void OnPlayerUsingCommand(PlayerUsingCommandEventArgs ev) => PlayerUsingCommand.CustomInvoke(ev);
        
        /**
         *
         * RespawnPointChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerRespawnPointChangedEventArgs> RespawnPointChanged;

        /**
         *
         * RespawnPointChanged Olayı 
         *
         
         *
         */
        public static void OnRespawnPointChanged(PlayerRespawnPointChangedEventArgs ev) => RespawnPointChanged.CustomInvoke(ev);
        
        /**
         *
         * Freezed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerFreezedEventArgs> Freezed;

        /**
         *
         * Freezed Olayı 
         *
         
         *
         */
        public static void OnFreezed(PlayerFreezedEventArgs ev) => Freezed.CustomInvoke(ev);
        
        /**
         *
         * Unfreezed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler Unfreezed;

        /**
         *
         * Unfreezed Olayı 
         *
         
         *
         */
        public static void OnUnfreezed() => Unfreezed.CustomInvoke();
    }
}
