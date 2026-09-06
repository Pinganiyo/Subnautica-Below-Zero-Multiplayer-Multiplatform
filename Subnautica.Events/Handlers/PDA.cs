namespace Subnautica.Events.Handlers
{
    using Subnautica.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class PDA
    {
        /**
         *
         * EncyclopediaAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<EncyclopediaAddedEventArgs> EncyclopediaAdded;

        /**
         *
         * EncyclopediaAdded Olayı 
         *
         
         *
         */
        public static void OnEncyclopediaAdded(EncyclopediaAddedEventArgs ev) => EncyclopediaAdded.CustomInvoke(ev);

        /**
         *
         * TechnologyFragmentAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TechnologyFragmentAddedEventArgs> TechnologyFragmentAdded;

        /**
         *
         * TechnologyFragmentAdded Olayı 
         *
         
         *
         */
        public static void OnTechnologyFragmentAdded(TechnologyFragmentAddedEventArgs ev) => TechnologyFragmentAdded.CustomInvoke(ev);

        /**
         *
         * TechnologyAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TechnologyAddedEventArgs> TechnologyAdded;

        /**
         *
         * TechnologyAdded Olayı 
         *
         
         *
         */
        public static void OnTechnologyAdded(TechnologyAddedEventArgs ev) => TechnologyAdded.CustomInvoke(ev);

        /**
         *
         * ScannerCompleted İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<ScannerCompletedEventArgs> ScannerCompleted;

        /**
         *
         * ScannerCompleted Olayı 
         *
         
         *
         */
        public static void OnScannerCompleted(ScannerCompletedEventArgs ev) => ScannerCompleted.CustomInvoke(ev);

        /**
         *
         * ItemPinAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler ItemPinAdded;

        /**
         *
         * ItemPinAdded Olayı 
         *
         
         *
         */
        public static void OnItemPinAdded() => ItemPinAdded.CustomInvoke();

        /**
         *
         * ItemPinRemoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler ItemPinRemoved;

        /**
         *
         * ItemPinRemoved Olayı 
         *
         
         *
         */
        public static void OnItemPinRemoved() => ItemPinRemoved.CustomInvoke();

        /**
         *
         * ItemPinMoved İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler ItemPinMoved;

        /**
         *
         * ItemPinMoved Olayı 
         *
         
         *
         */
        public static void OnItemPinMoved() => ItemPinMoved.CustomInvoke();

        /**
         *
         * LogAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PDALogAddedEventArgs> LogAdded;

        /**
         *
         * LogAdded Olayı 
         *
         
         *
         */
        public static void OnLogAdded(PDALogAddedEventArgs ev) => LogAdded.CustomInvoke(ev);

        /**
         *
         * NotificationToggle İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<NotificationToggleEventArgs> NotificationToggle;

        /**
         *
         * NotificationToggle Olayı 
         *
         
         *
         */
        public static void OnNotificationToggle(NotificationToggleEventArgs ev) => NotificationToggle.CustomInvoke(ev);

        /**
         *
         * TechAnalyzeAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<TechAnalyzeAddedEventArgs> TechAnalyzeAdded;

        /**
         *
         * TechAnalyzeAdded Olayı 
         *
         
         *
         */
        public static void OnTechAnalyzeAdded(TechAnalyzeAddedEventArgs ev) => TechAnalyzeAdded.CustomInvoke(ev);

        /**
         *
         * JukeboxDiskAdded İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<JukeboxDiskAddedEventArgs> JukeboxDiskAdded;

        /**
         *
         * JukeboxDiskAdded Olayı 
         *
         
         *
         */
        public static void OnJukeboxDiskAdded(JukeboxDiskAddedEventArgs ev) => JukeboxDiskAdded.CustomInvoke(ev);

        /**
         *
         * Closing İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PDAClosingEventArgs> Closing;

        /**
         *
         * Closing Olayı 
         *
         
         *
         */
        public static void OnClosing(PDAClosingEventArgs ev) => Closing.CustomInvoke(ev);
    }
}