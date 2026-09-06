namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Building
    {
        /**
         *
         * ConstructingGhostMoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructionGhostMovedEventArgs> ConstructingGhostMoved;

        /**
         *
         * ConstructingGhostMoved Olayı 
         *
         
         *
         */
        public static void OnConstructingGhostMoved(ConstructionGhostMovedEventArgs ev) => ConstructingGhostMoved.CustomInvoke(ev);

        /**
         *
         * ConstructingGhostTryPlacing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructionGhostTryPlacingEventArgs> ConstructingGhostTryPlacing;

        /**
         *
         * ConstructingGhostTryPlacing Olayı 
         *
         
         *
         */
        public static void OnConstructingGhostTryPlacing(ConstructionGhostTryPlacingEventArgs ev) => ConstructingGhostTryPlacing.CustomInvoke(ev);

        /**
         *
         * ConstructingAmountChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructionAmountChangedEventArgs> ConstructingAmountChanged;

        /**
         *
         * ConstructingGhostTryPlacing Olayı 
         *
         
         *
         */
        public static void OnConstructingAmountChanged(ConstructionAmountChangedEventArgs ev) => ConstructingAmountChanged.CustomInvoke(ev);

        /**
         *
         * ConstructingCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructionCompletedEventArgs> ConstructingCompleted;

        /**
         *
         * ConstructingCompleted Olayı 
         *
         
         *
         */
        public static void OnConstructingCompleted(ConstructionCompletedEventArgs ev) => ConstructingCompleted.CustomInvoke(ev);
        /**
         *
         * ConstructingRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ConstructionRemovedEventArgs> ConstructingRemoved;

        /**
         *
         * ConstructingRemoved Olayı 
         *
         
         *
         */
        public static void OnConstructingRemoved(ConstructionRemovedEventArgs ev) => ConstructingRemoved.CustomInvoke(ev);

        /**
         *
         * DeconstructionBegin İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<DeconstructionBeginEventArgs> DeconstructionBegin;

        /**
         *
         * DeconstructionBegin Olayı 
         *
         
         *
         */
        public static void OnDeconstructionBegin(DeconstructionBeginEventArgs ev) => DeconstructionBegin.CustomInvoke(ev);

        /**
         *
         * FurnitureDeconstructionBegin İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<FurnitureDeconstructionBeginEventArgs> FurnitureDeconstructionBegin;

        /**
         *
         * FurnitureDeconstructionBegin Olayı 
         *
         
         *
         */
        public static void OnFurnitureDeconstructionBegin(FurnitureDeconstructionBeginEventArgs ev) => FurnitureDeconstructionBegin.CustomInvoke(ev);

        /**
         *
         * BaseHullStrengthCrushing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<BaseHullStrengthCrushingEventArgs> BaseHullStrengthCrushing;

        /**
         *
         * BaseHullStrengthCrushing Olayı 
         *
         
         *
         */
        public static void OnBaseHullStrengthCrushing(BaseHullStrengthCrushingEventArgs ev) => BaseHullStrengthCrushing.CustomInvoke(ev);
    }
}