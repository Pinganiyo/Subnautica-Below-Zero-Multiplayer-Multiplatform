namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Inventory
    {
        /**
         *
         * ItemRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<InventoryItemRemovedEventArgs> ItemRemoved;

        /**
         *
         * ItemRemoved Olayı 
         *
         
         *
         */
        public static void OnItemRemoved(InventoryItemRemovedEventArgs ev) => ItemRemoved.CustomInvoke(ev);

        /**
         *
         * ItemAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<InventoryItemAddedEventArgs> ItemAdded;

        /**
         *
         * ItemAdded Olayı 
         *
         
         *
         */
        public static void OnItemAdded(InventoryItemAddedEventArgs ev) => ItemAdded.CustomInvoke(ev);

        /**
         *
         * QuickSlotBinded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler QuickSlotBinded;

        /**
         *
         * QuickSlotBinded Olayı 
         *
         
         *
         */
        public static void OnQuickSlotBinded() => QuickSlotBinded.CustomInvoke();

        /**
         *
         * QuickSlotUnbinded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler QuickSlotUnbinded;

        /**
         *
         * QuickSlotUnbinded Olayı 
         *
         
         *
         */
        public static void OnQuickSlotUnbinded() => QuickSlotUnbinded.CustomInvoke();

        /**
         *
         * EquipmentEquiped İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler EquipmentEquiped;

        /**
         *
         * EquipmentEquiped Olayı 
         *
         
         *
         */
        public static void OnEquipmentEquiped() => EquipmentEquiped.CustomInvoke();

        /**
         *
         * EquipmentUnequiped İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler EquipmentUnequiped;

        /**
         *
         * EquipmentUnequiped Olayı 
         *
         
         *
         */
        public static void OnEquipmentUnequiped() => EquipmentUnequiped.CustomInvoke();

        /**
         *
         * QuickSlotActiveChanged İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<QuickSlotActiveChangedEventArgs> QuickSlotActiveChanged;

        /**
         *
         * QuickSlotActiveChanged Olayı 
         *
         
         *
         */
        public static void OnQuickSlotActiveChanged(QuickSlotActiveChangedEventArgs ev) => QuickSlotActiveChanged.CustomInvoke(ev);
    }
}