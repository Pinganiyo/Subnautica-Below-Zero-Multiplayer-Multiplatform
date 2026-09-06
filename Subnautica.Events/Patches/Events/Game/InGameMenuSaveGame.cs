namespace Subnautica.Events.Patches.Events.Game
{
    using System;

    using HarmonyLib;

    using Subnautica.API.Features;
    using Subnautica.Events.EventArgs;

    using UnityEngine;

    [HarmonyPatch(typeof(IngameMenu), nameof(IngameMenu.SaveGame))]
    public class InGameMenuSaveGame
    {
        private static bool Prefix(IngameMenu __instance)
        {
            if (!Network.IsMultiplayerActive)
            {
                return true;
            }

            try
            {
                var args = new InGameMenuSaveGameEventArgs();
                Handlers.Game.OnInGameMenuSaveGame(args);

                if (args.IsHandled)
                {
                    __instance.lastSavedStateTime = Time.unscaledTime;
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                Log.Error($"InGameMenuSaveGame.Prefix: {e}\n{e.StackTrace}");
                return false;
            }
        }
    }
}
