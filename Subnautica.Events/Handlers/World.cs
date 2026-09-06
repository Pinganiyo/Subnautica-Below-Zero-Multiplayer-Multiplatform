namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class World
    {
        /**
         *
         * ThermalLilyRangeChecking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ThermalLilyRangeCheckingEventArgs> ThermalLilyRangeChecking;

        /**
         *
         * ThermalLilyRangeChecking Olayı 
         *
         
         *
         */
        public static void OnThermalLilyRangeChecking(ThermalLilyRangeCheckingEventArgs ev) => ThermalLilyRangeChecking.CustomInvoke(ev);

        /**
         *
         * ThermalLilyAnimationAnglesChecking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ThermalLilyAnimationAnglesCheckingEventArgs> ThermalLilyAnimationAnglesChecking;

        /**
         *
         * ThermalLilyAnimationAnglesChecking Olayı 
         *
         
         *
         */
        public static void OnThermalLilyAnimationAnglesChecking(ThermalLilyAnimationAnglesCheckingEventArgs ev) => ThermalLilyAnimationAnglesChecking.CustomInvoke(ev);

        /**
         *
         * OxygenPlantClicking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<OxygenPlantClickingEventArgs> OxygenPlantClicking;

        /**
         *
         * OxygenPlantClicking Olayı 
         *
         
         *
         */
        public static void OnOxygenPlantClicking(OxygenPlantClickingEventArgs ev) => OxygenPlantClicking.CustomInvoke(ev);

        /**
         *
         * EntitySpawning İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EntitySpawningEventArgs> EntitySpawning;

        /**
         *
         * EntitySpawning Olayı 
         *
         
         *
         */
        public static void OnEntitySpawning(EntitySpawningEventArgs ev) => EntitySpawning.CustomInvoke(ev);

        /**
         *
         * AlterraPdaPickedUp İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<AlterraPdaPickedUpEventArgs> AlterraPdaPickedUp;

        /**
         *
         * AlterraPdaPickedUp Olayı 
         *
         
         *
         */
        public static void OnAlterraPdaPickedUp(AlterraPdaPickedUpEventArgs ev) => AlterraPdaPickedUp.CustomInvoke(ev);

        /**
         *
         * JukeboxDiskPickedUp İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<JukeboxDiskPickedUpEventArgs> JukeboxDiskPickedUp;

        /**
         *
         * JukeboxDiskPickedUp Olayı 
         *
         
         *
         */
        public static void OnJukeboxDiskPickedUp(JukeboxDiskPickedUpEventArgs ev) => JukeboxDiskPickedUp.CustomInvoke(ev);

        /**
         *
         * EntitySpawned İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EntitySpawnedEventArgs> EntitySpawned;

        /**
         *
         * EntitySpawned Olayı 
         *
         
         *
         */
        public static void OnEntitySpawned(EntitySpawnedEventArgs ev) => EntitySpawned.CustomInvoke(ev);

        /**
         *
         * SupplyCrateOpened İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SupplyCrateOpenedEventArgs> SupplyCrateOpened;

        /**
         *
         * SupplyCrateOpened Olayı 
         *
         
         *
         */
        public static void OnSupplyCrateOpened(SupplyCrateOpenedEventArgs ev) => SupplyCrateOpened.CustomInvoke(ev);

        /**
         *
         * DataboxItemPickedUp İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<DataboxItemPickedUpEventArgs> DataboxItemPickedUp;

        /**
         *
         * DataboxItemPickedUp Olayı 
         *
         
         *
         */
        public static void OnDataboxItemPickedUp(DataboxItemPickedUpEventArgs ev) => DataboxItemPickedUp.CustomInvoke(ev);

        /**
         *
         * TakeDamaging İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TakeDamagingEventArgs> TakeDamaging;

        /**
         *
         * TakeDamaging Olayı 
         *
         
         *
         */
        public static void OnTakeDamaging(TakeDamagingEventArgs ev) => TakeDamaging.CustomInvoke(ev);

        /**
         *
         * FruitHarvesting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<FruitHarvestingEventArgs> FruitHarvesting;

        /**
         *
         * FruitHarvesting Olayı 
         *
         
         *
         */
        public static void OnFruitHarvesting(FruitHarvestingEventArgs ev) => FruitHarvesting.CustomInvoke(ev);

        /**
         *
         * CellLoading İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CellLoadingEventArgs> CellLoading;

        /**
         *
         * CellLoading Olayı 
         *
         
         *
         */
        public static void OnCellLoading(CellLoadingEventArgs ev) => CellLoading.CustomInvoke(ev);

        /**
         *
         * CellUnLoading İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CellUnLoadingEventArgs> CellUnLoading;

        /**
         *
         * CellUnLoading Olayı 
         *
         
         *
         */
        public static void OnCellUnLoading(CellUnLoadingEventArgs ev) => CellUnLoading.CustomInvoke(ev);

        /**
         *
         * GrownPlantHarvesting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<GrownPlantHarvestingEventArgs> GrownPlantHarvesting;

        /**
         *
         * GrownPlantHarvesting Olayı 
         *
         
         *
         */
        public static void OnGrownPlantHarvesting(GrownPlantHarvestingEventArgs ev) => GrownPlantHarvesting.CustomInvoke(ev);

        /**
         *
         * EntitySlotSpawning İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EntitySlotSpawningEventArgs> EntitySlotSpawning;

        /**
         *
         * EntitySlotSpawning Olayı 
         *
         
         *
         */
        public static void OnEntitySlotSpawning(EntitySlotSpawningEventArgs ev) => EntitySlotSpawning.CustomInvoke(ev);

        /**
         *
         * LaserCutterUsing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LaserCutterEventArgs> LaserCutterUsing;

        /**
         *
         * LaserCutterUsing Olayı 
         *
         
         *
         */
        public static void OnLaserCutterUsing(LaserCutterEventArgs ev) => LaserCutterUsing.CustomInvoke(ev);

        /**
         *
         * SealedInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SealedInitializedEventArgs> SealedInitialized;

        /**
         *
         * SealedInitialized Olayı 
         *
         
         *
         */
        public static void OnSealedInitialized(SealedInitializedEventArgs ev) => SealedInitialized.CustomInvoke(ev);

        /**
         *
         * ElevatorCalling İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ElevatorCallingEventArgs> ElevatorCalling;

        /**
         *
         * ElevatorCalling Olayı 
         *
         
         *
         */
        public static void OnElevatorCalling(ElevatorCallingEventArgs ev) => ElevatorCalling.CustomInvoke(ev);

        /**
         *
         * SpawnOnKilling İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SpawnOnKillingEventArgs> SpawnOnKilling;

        /**
         *
         * SpawnOnKilling Olayı 
         *
         
         *
         */
        public static void OnSpawnOnKilling(SpawnOnKillingEventArgs ev) => SpawnOnKilling.CustomInvoke(ev);

        /**
         *
         * WeatherProfileChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<WeatherProfileChangedEventArgs> WeatherProfileChanged;

        /**
         *
         * WeatherProfileChanged Olayı 
         *
         
         *
         */
        public static void OnWeatherProfileChanged(WeatherProfileChangedEventArgs ev) => WeatherProfileChanged.CustomInvoke(ev);

        /**
         *
         * TeleporterTerminalActivating İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TeleporterTerminalActivatingEventArgs> TeleporterTerminalActivating;

        /**
         *
         * TeleporterTerminalActivating Olayı 
         *
         
         *
         */
        public static void OnTeleporterTerminalActivating(TeleporterTerminalActivatingEventArgs ev) => TeleporterTerminalActivating.CustomInvoke(ev);

        /**
         *
         * TeleporterInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TeleporterInitializedEventArgs> TeleporterInitialized;

        /**
         *
         * TeleporterInitialized Olayı 
         *
         
         *
         */
        public static void OnTeleporterInitialized(TeleporterInitializedEventArgs ev) => TeleporterInitialized.CustomInvoke(ev);

        /**
         *
         * ElevatorInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ElevatorInitializedEventArgs> ElevatorInitialized;

        /**
         *
         * ElevatorInitialized Olayı 
         *
         
         *
         */
        public static void OnElevatorInitialized(ElevatorInitializedEventArgs ev) => ElevatorInitialized.CustomInvoke(ev);

        /**
         *
         * CrushDamaging İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CrushDamagingEventArgs> CrushDamaging;

        /**
         *
         * CrushDamaging Olayı 
         *
         
         *
         */
        public static void OnCrushDamaging(CrushDamagingEventArgs ev) => CrushDamaging.CustomInvoke(ev);

        /**
         *
         * CosmeticItemPlacing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<CosmeticItemPlacingEventArgs> CosmeticItemPlacing;

        /**
         *
         * CosmeticItemPlacing Olayı 
         *
         
         *
         */
        public static void OnCosmeticItemPlacing(CosmeticItemPlacingEventArgs ev) => CosmeticItemPlacing.CustomInvoke(ev);
    }
}