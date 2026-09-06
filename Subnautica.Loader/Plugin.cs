namespace Subnautica.Loader
{
    using System;
    using BepInEx;
    using BepInEx.Logging;
    using HarmonyLib;

    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "com.botbenson.subnauticamultiplayer";
        public const string PluginName = "Subnautica Below Zero Multiplayer";
        public const string PluginVersion = "1.0.0";

        internal static ManualLogSource LogSource;

        private void Awake()
        {
            LogSource = this.Logger;
            LogSource.LogInfo("Initializing Subnautica Below Zero Multiplayer...");

            try
            {
                // Initialize Subnautica.Events
                var eventsPlugin = new Subnautica.Events.Main();
                eventsPlugin.OnEnabled();
                LogSource.LogInfo("Subnautica.Events initialized successfully.");

                // Initialize Subnautica.Client
                var clientPlugin = new Subnautica.Client.Main();
                clientPlugin.OnEnabled();
                LogSource.LogInfo("Subnautica.Client initialized successfully.");
            }
            catch (Exception ex)
            {
                LogSource.LogError($"Failed to initialize Subnautica Below Zero Multiplayer: {ex}");
            }
        }
    }
}
