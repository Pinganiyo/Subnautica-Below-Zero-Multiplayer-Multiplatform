namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Items
    {
        /**
         *
         * KnifeUsing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<KnifeUsingEventArgs> KnifeUsing;

        /**
         *
         * KnifeUsing Olayı 
         *
         
         *
         */
        public static void OnKnifeUsing(KnifeUsingEventArgs ev) => KnifeUsing.CustomInvoke(ev);
        
        /**
         *
         * ScannerUsing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ScannerUsingEventArgs> ScannerUsing;

        /**
         *
         * ScannerUsing Olayı 
         *
         
         *
         */
        public static void OnScannerUsing(ScannerUsingEventArgs ev) => ScannerUsing.CustomInvoke(ev);
        
        /**
         *
         * ConstructorDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructorDeployingEventArgs> ConstructorDeploying;

        /**
         *
         * ConstructorDeploying Olayı 
         *
         
         *
         */
        public static void OnConstructorDeploying(ConstructorDeployingEventArgs ev) => ConstructorDeploying.CustomInvoke(ev);
        
        /**
         *
         * ConstructorEngageToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructorEngageToggleEventArgs> ConstructorEngageToggle;

        /**
         *
         * ConstructorEngageToggle Olayı 
         *
         
         *
         */
        public static void OnConstructorEngageToggle(ConstructorEngageToggleEventArgs ev) => ConstructorEngageToggle.CustomInvoke(ev);
        
        /**
         *
         * ConstructorCrafting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructorCraftingEventArgs> ConstructorCrafting;

        /**
         *
         * ConstructorCrafting Olayı 
         *
         
         *
         */
        public static void OnConstructorCrafting(ConstructorCraftingEventArgs ev) => ConstructorCrafting.CustomInvoke(ev);
        
        /**
         *
         * HoverbikeDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<HoverbikeDeployingEventArgs> HoverbikeDeploying;

        /**
         *
         * HoverbikeDeploying Olayı 
         *
         
         *
         */
        public static void OnHoverbikeDeploying(HoverbikeDeployingEventArgs ev) => HoverbikeDeploying.CustomInvoke(ev);
        
        /**
         *
         * DeployableStorageDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<DeployableStorageDeployingEventArgs> DeployableStorageDeploying;

        /**
         *
         * DeployableStorageDeploying Olayı 
         *
         
         *
         */
        public static void OnDeployableStorageDeploying(DeployableStorageDeployingEventArgs ev) => DeployableStorageDeploying.CustomInvoke(ev);
        
        /**
         *
         * LEDLightDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LEDLightDeployingEventArgs> LEDLightDeploying;

        /**
         *
         * LEDLightDeploying Olayı 
         *
         
         *
         */
        public static void OnLEDLightDeploying(LEDLightDeployingEventArgs ev) => LEDLightDeploying.CustomInvoke(ev);
        
        /**
         *
         * BeaconDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BeaconDeployingEventArgs> BeaconDeploying;

        /**
         *
         * BeaconDeploying Olayı 
         *
         
         *
         */
        public static void OnBeaconDeploying(BeaconDeployingEventArgs ev) => BeaconDeploying.CustomInvoke(ev);
        
        /**
         *
         * FlareDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<FlareDeployingEventArgs> FlareDeploying;

        /**
         *
         * FlareDeploying Olayı 
         *
         
         *
         */
        public static void OnFlareDeploying(FlareDeployingEventArgs ev) => FlareDeploying.CustomInvoke(ev);
        
        /**
         *
         * ThumperDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ThumperDeployingEventArgs> ThumperDeploying;

        /**
         *
         * ThumperDeploying Olayı 
         *
         
         *
         */
        public static void OnThumperDeploying(ThumperDeployingEventArgs ev) => ThumperDeploying.CustomInvoke(ev);
        
        /**
         *
         * TeleportationToolUsed İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TeleportationToolUsedEventArgs> TeleportationToolUsed;

        /**
         *
         * TeleportationToolUsed Olayı 
         *
         
         *
         */
        public static void OnTeleportationToolUsed(TeleportationToolUsedEventArgs ev) => TeleportationToolUsed.CustomInvoke(ev);
        
        /**
         *
         * BeaconLabelChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BeaconLabelChangedEventArgs> BeaconLabelChanged;

        /**
         *
         * BeaconLabelChanged Olayı 
         *
         
         *
         */
        public static void OnBeaconLabelChanged(BeaconLabelChangedEventArgs ev) => BeaconLabelChanged.CustomInvoke(ev);
        
        /**
         *
         * SpyPenguinDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SpyPenguinDeployingEventArgs> SpyPenguinDeploying;

        /**
         *
         * SpyPenguinDeploying Olayı 
         *
         
         *
         */
        public static void OnSpyPenguinDeploying(SpyPenguinDeployingEventArgs ev) => SpyPenguinDeploying.CustomInvoke(ev);
        
        /**
         *
         * SpyPenguinItemPickedUp İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SpyPenguinItemPickedUpEventArgs> SpyPenguinItemPickedUp;

        /**
         *
         * SpyPenguinItemPickedUp Olayı 
         *
         
         *
         */
        public static void OnSpyPenguinItemPickedUp(SpyPenguinItemPickedUpEventArgs ev) => SpyPenguinItemPickedUp.CustomInvoke(ev);
        
        /**
         *
         * SpyPenguinSnowStalkerInteracting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SpyPenguinSnowStalkerInteractingEventArgs> SpyPenguinSnowStalkerInteracting;

        /**
         *
         * SpyPenguinSnowStalkerInteracting Olayı 
         *
         
         *
         */
        public static void OnSpyPenguinSnowStalkerInteracting(SpyPenguinSnowStalkerInteractingEventArgs ev) => SpyPenguinSnowStalkerInteracting.CustomInvoke(ev);
        
        /**
         *
         * SpyPenguinItemGrabing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SpyPenguinItemGrabingEventArgs> SpyPenguinItemGrabing;

        /**
         *
         * SpyPenguinItemGrabing Olayı 
         *
         
         *
         */
        public static void OnSpyPenguinItemGrabing(SpyPenguinItemGrabingEventArgs ev) => SpyPenguinItemGrabing.CustomInvoke(ev);
        
        /**
         *
         * Welding İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<WeldingEventArgs> Welding;

        /**
         *
         * Welding Olayı 
         *
         
         *
         */
        public static void OnWelding(WeldingEventArgs ev) => Welding.CustomInvoke(ev);
        
        /**
         *
         * DroneCameraDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<DroneCameraDeployingEventArgs> DroneCameraDeploying;

        /**
         *
         * DroneCameraDeploying Olayı 
         *
         
         *
         */
        public static void OnDroneCameraDeploying(DroneCameraDeployingEventArgs ev) => DroneCameraDeploying.CustomInvoke(ev);
        
        /**
         *
         * PipeSurfaceFloaterDeploying İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PipeSurfaceFloaterDeployingEventArgs> PipeSurfaceFloaterDeploying;

        /**
         *
         * PipeSurfaceFloaterDeploying Olayı 
         *
         
         *
         */
        public static void OnPipeSurfaceFloaterDeploying(PipeSurfaceFloaterDeployingEventArgs ev) => PipeSurfaceFloaterDeploying.CustomInvoke(ev);
        
        /**
         *
         * OxygenPipePlacing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<OxygenPipePlacingEventArgs> OxygenPipePlacing;

        /**
         *
         * OxygenPipePlacing Olayı 
         *
         
         *
         */
        public static void OnOxygenPipePlacing(OxygenPipePlacingEventArgs ev) => OxygenPipePlacing.CustomInvoke(ev);
    }
}
