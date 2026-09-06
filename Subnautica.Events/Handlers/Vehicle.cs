namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Vehicle
    {
        /**
         *
         * UpgradeConsoleOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<UpgradeConsoleOpeningEventArgs> UpgradeConsoleOpening;

        /**
         *
         * UpgradeConsoleOpening Olayı 
         *
         
         *
         */
        public static void OnUpgradeConsoleOpening(UpgradeConsoleOpeningEventArgs ev) => UpgradeConsoleOpening.CustomInvoke(ev);

        /**
         *
         * UpgradeConsoleModuleAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<UpgradeConsoleModuleAddedEventArgs> UpgradeConsoleModuleAdded;

        /**
         *
         * UpgradeConsoleModuleAdded Olayı 
         *
         
         *
         */
        public static void OnUpgradeConsoleModuleAdded(UpgradeConsoleModuleAddedEventArgs ev) => UpgradeConsoleModuleAdded.CustomInvoke(ev);

        /**
         *
         * UpgradeConsoleModuleRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<UpgradeConsoleModuleRemovedEventArgs> UpgradeConsoleModuleRemoved;

        /**
         *
         * UpgradeConsoleModuleRemoved Olayı 
         *
         
         *
         */
        public static void OnUpgradeConsoleModuleRemoved(UpgradeConsoleModuleRemovedEventArgs ev) => UpgradeConsoleModuleRemoved.CustomInvoke(ev);

        /**
         *
         * Entering İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<VehicleEnteringEventArgs> Entering;

        /**
         *
         * Entering Olayı 
         *
         
         *
         */
        public static void OnEntering(VehicleEnteringEventArgs ev) => Entering.CustomInvoke(ev);

        /**
         *
         * InteriorToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<VehicleInteriorToggleEventArgs> InteriorToggle;

        /**
         *
         * InteriorToggle Olayı 
         *
         
         *
         */
        public static void OnInteriorToggle(VehicleInteriorToggleEventArgs ev) => InteriorToggle.CustomInvoke(ev);

        /**
         *
         * Exited İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<VehicleExitedEventArgs> Exited;

        /**
         *
         * Exited Olayı 
         *
         
         *
         */
        public static void OnExited(VehicleExitedEventArgs ev) => Exited.CustomInvoke(ev);

        /**
         *
         * Updated İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<VehicleUpdatedEventArgs> Updated;

        /**
         *
         * Updated Olayı 
         *
         
         *
         */
        public static void OnUpdated(VehicleUpdatedEventArgs ev) => Updated.CustomInvoke(ev);

        /**
         *
         * LightChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<LightChangedEventArgs> LightChanged;

        /**
         *
         * LightChanged Olayı 
         *
         
         *
         */
        public static void OnLightChanged(LightChangedEventArgs ev) => LightChanged.CustomInvoke(ev);

        /**
         *
         * SeaTruckConnecting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SeaTruckConnectingEventArgs> SeaTruckConnecting;

        /**
         *
         * SeaTruckConnecting Olayı 
         *
         
         *
         */
        public static void OnSeaTruckConnecting(SeaTruckConnectingEventArgs ev) => SeaTruckConnecting.CustomInvoke(ev);

        /**
         *
         * ExosuitJumping İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ExosuitJumpingEventArgs> ExosuitJumping;

        /**
         *
         * ExosuitJumping Olayı 
         *
         
         *
         */
        public static void OnExosuitJumping(ExosuitJumpingEventArgs ev) => ExosuitJumping.CustomInvoke(ev);

        /**
         *
         * SeaTruckDetaching İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SeaTruckDetachingEventArgs> SeaTruckDetaching;

        /**
         *
         * SeaTruckDetaching Olayı 
         *
         
         *
         */
        public static void OnSeaTruckDetaching(SeaTruckDetachingEventArgs ev) => SeaTruckDetaching.CustomInvoke(ev);

        /**
         *
         * ExosuitItemPickedUp İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ExosuitItemPickedUpEventArgs> ExosuitItemPickedUp;

        /**
         *
         * ExosuitItemPickedUp Olayı 
         *
         
         *
         */
        public static void OnExosuitItemPickedUp(ExosuitItemPickedUpEventArgs ev) => ExosuitItemPickedUp.CustomInvoke(ev);

        /**
         *
         * ExosuitDrilling İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ExosuitDrillingEventArgs> ExosuitDrilling;

        /**
         *
         * ExosuitDrilling Olayı 
         *
         
         *
         */
        public static void OnExosuitDrilling(ExosuitDrillingEventArgs ev) => ExosuitDrilling.CustomInvoke(ev);

        /**
         *
         * Docking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<VehicleDockingEventArgs> Docking;

        /**
         *
         * Docking Olayı 
         *
         
         *
         */
        public static void OnDocking(VehicleDockingEventArgs ev) => Docking.CustomInvoke(ev);

        /**
         *
         * Undocking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<VehicleUndockingEventArgs> Undocking;

        /**
         *
         * Undocking Olayı 
         *
         
         *
         */
        public static void OnUndocking(VehicleUndockingEventArgs ev) => Undocking.CustomInvoke(ev);

        /**
         *
         * SeaTruckPictureFrameOpening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SeaTruckPictureFrameOpeningEventArgs> SeaTruckPictureFrameOpening;

        /**
         *
         * SeaTruckPictureFrameOpening Olayı 
         *
         
         *
         */
        public static void OnSeaTruckPictureFrameOpening(SeaTruckPictureFrameOpeningEventArgs ev) => SeaTruckPictureFrameOpening.CustomInvoke(ev);

        /**
         *
         * SeaTruckPictureFrameImageSelecting İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SeaTruckPictureFrameImageSelectingEventArgs> SeaTruckPictureFrameImageSelecting;

        /**
         *
         * SeaTruckPictureFrameImageSelecting Olayı 
         *
         
         *
         */
        public static void OnSeaTruckPictureFrameImageSelecting(SeaTruckPictureFrameImageSelectingEventArgs ev) => SeaTruckPictureFrameImageSelecting.CustomInvoke(ev);

        /**
         *
         * MapRoomCameraDocking İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<MapRoomCameraDockingEventArgs> MapRoomCameraDocking;

        /**
         *
         * MapRoomCameraDocking Olayı 
         *
         
         *
         */
        public static void OnMapRoomCameraDocking(MapRoomCameraDockingEventArgs ev) => MapRoomCameraDocking.CustomInvoke(ev);

        /**
         *
         * SeaTruckModuleInitialized İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<SeaTruckModuleInitializedEventArgs> SeaTruckModuleInitialized;

        /**
         *
         * SeaTruckModuleInitialized Olayı 
         *
         
         *
         */
        public static void OnSeaTruckModuleInitialized(SeaTruckModuleInitializedEventArgs ev) => SeaTruckModuleInitialized.CustomInvoke(ev);
    }
}