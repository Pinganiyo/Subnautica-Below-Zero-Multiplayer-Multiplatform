namespace Subnautica.Client.Modules
{
    using System;

    using Subnautica.API.Features;
    using Subnautica.Client.Core;
    using Subnautica.Client.Multiplayer.Cinematics;
    using Subnautica.Events.EventArgs;

    public class MainProcess
    {
        /**
         *
         * Eklenti aktifleştiğinde tetiklenir.
         *
         
         *
         */
        public static void OnPluginEnabled()
        {
            ZeroLanguage.LoadLanguage(Tools.GetLanguage());
        }

        /**
         *
         * Oyuncu ana menüye gittiğinde tetiklenir.
         *
         
         *
         */
        public static void OnQuittingToMainMenu(QuittingToMainMenuEventArgs ev)
        {
            if (Network.IsHost)
            {
                NetworkServer.SaveGame();
            }

            ClearAllCache();
        }

        /**
         *
         * Oyun kapatılırken tetiklenir.
         *
         */
        public static void OnQuitting()
        {
            if (Network.IsHost)
            {
                NetworkServer.SaveGame();
            }

            ClearAllCache();
        }

        /**
         *
         * Sahne yüklendiğinde tetiklenir.
         *
         
         *
         */
        public static void OnSceneLoaded(SceneLoadedEventArgs ev)
        {
            if (ev.Scene.name == "XMenu")
            {
                ClearAllCache();
            }
        }

        /**
         *
         * Tüm önbelleği temizler.
         *
         
         *
         */
        public static void ClearAllCache()
        {
            try
            {
                QualitySetting.DisableFastMode();
                Network.Dispose();
                NetworkServer.AbortServer();
                NetworkClient.Disconnect();

                PlayerCinematicQueue.Dispose();
                Multiplayer.Furnitures.Bed.Dispose();
            }
            catch (Exception e)
            {
                Log.Error($"ClearAllCache Exception: {e}");
            }
        }
    }
}