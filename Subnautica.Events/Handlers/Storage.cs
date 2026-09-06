namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Storage
    {
        /**
         *
         * Opening İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StorageOpeningEventArgs> Opening;

        /**
         *
         * Opening Olayı 
         *
         
         *
         */
        public static void OnOpening(StorageOpeningEventArgs ev) => Opening.CustomInvoke(ev);

        /**
         *
         * ItemAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StorageItemAddedEventArgs> ItemAdded;

        /**
         *
         * ItemAdded Olayı 
         *
         
         *
         */
        public static void OnItemAdded(StorageItemAddedEventArgs ev) => ItemAdded.CustomInvoke(ev);

        /**
         *
         * ItemRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StorageItemRemovedEventArgs> ItemRemoved;

        /**
         *
         * ItemRemoved Olayı 
         *
         
         *
         */
        public static void OnItemRemoved(StorageItemRemovedEventArgs ev) => ItemRemoved.CustomInvoke(ev);

        /**
         *
         * NuclearReactorItemAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<NuclearReactorItemAddedEventArgs> NuclearReactorItemAdded;

        /**
         *
         * NuclearReactorItemAdded Olayı 
         *
         
         *
         */
        public static void OnNuclearReactorItemAdded(NuclearReactorItemAddedEventArgs ev) => NuclearReactorItemAdded.CustomInvoke(ev);

        /**
         *
         * NuclearReactorItemRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<NuclearReactorItemRemovedEventArgs> NuclearReactorItemRemoved;

        /**
         *
         * NuclearReactorItemRemoved Olayı 
         *
         
         *
         */
        public static void OnNuclearReactorItemRemoved(NuclearReactorItemRemovedEventArgs ev) => NuclearReactorItemRemoved.CustomInvoke(ev);

        /**
         *
         * ChargerItemAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ChargerItemAddedEventArgs> ChargerItemAdded;

        /**
         *
         * ChargerItemAdded Olayı 
         *
         
         *
         */
        public static void OnChargerItemAdded(ChargerItemAddedEventArgs ev) => ChargerItemAdded.CustomInvoke(ev);

        /**
         *
         * ChargerItemRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ChargerItemRemovedEventArgs> ChargerItemRemoved;

        /**
         *
         * ChargerItemRemoved Olayı 
         *
         
         *
         */
        public static void OnChargerItemRemoved(ChargerItemRemovedEventArgs ev) => ChargerItemRemoved.CustomInvoke(ev);

        /**
         *
         * ItemRemoving İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StorageItemRemovingEventArgs> ItemRemoving;

        /**
         *
         * ItemRemoving Olayı 
         *
         
         *
         */
        public static void OnItemRemoving(StorageItemRemovingEventArgs ev) => ItemRemoving.CustomInvoke(ev);

        /**
         *
         * ItemAdding İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<StorageItemAddingEventArgs> ItemAdding;

        /**
         *
         * ItemAdding Olayı 
         *
         
         *
         */
        public static void OnItemAdding(StorageItemAddingEventArgs ev) => ItemAdding.CustomInvoke(ev);
    }
}