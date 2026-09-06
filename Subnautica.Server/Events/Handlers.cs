namespace Subnautica.Server.Events
{
    using Subnautica.Server.Events.EventArgs;

    using static Subnautica.API.Extensions.EventExtensions;

    public class Handlers
    {
        /**
         *
         * PlayerFullConnected İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerFullConnectedEventArgs> PlayerFullConnected;

        /**
         *
         * PlayerFullConnected Olayı 
         *
         
         *
         */
        public static void OnPlayerFullConnected(PlayerFullConnectedEventArgs ev) => PlayerFullConnected.CustomInvoke(ev);

        /**
         *
         * PlayerDisconnected İşleyicisi
         *
         
         *
         */
        public static event SubnauticaPluginEventHandler<PlayerDisconnectedEventArgs> PlayerDisconnected;

        /**
         *
         * PlayerDisconnected Olayı 
         *
         
         *
         */
        public static void OnPlayerDisconnected(PlayerDisconnectedEventArgs ev) => PlayerDisconnected.CustomInvoke(ev);
    }
}
