namespace Subnautica.Events.Patches.Fixes.Player
{
    using HarmonyLib;

    using Subnautica.API.Extensions;
    using Subnautica.API.Features;

    using UnityEngine;

    [HarmonyPatch(typeof(MainGameController), nameof(MainGameController.SetInitialPlayerPosition))]
    public class WorldLoadingBefore
    {
        private static bool Prefix(MainGameController __instance)
        {
            if (!Network.IsMultiplayerActive)
            {
                return true;
            }

            if (Network.Session.Current != null && Network.Session.Current.PlayerPosition != null && Network.Session.Current.PlayerPosition.ToVector3() != Vector3.zero)
            {
                return false;
            }

            if (global::Player.main != null)
            {
                var storyVer = SaveLoadManager.main != null && (int)SaveLoadManager.main.storyVersion > 0 
                    ? SaveLoadManager.main.storyVersion 
                    : (SaveLoadManager.StoryVersion)SaveLoadManager.defaultStoryVersion;

                if (SaveLoadManager.main != null && (int)SaveLoadManager.main.storyVersion == 0)
                {
                    SaveLoadManager.main.storyVersion = storyVer;
                }

                var gameData = global::Player.main.GetGameData(storyVer);
                if (gameData != null)
                {
                    if (GameModeManager.GetOption<bool>(GameOption.Story))
                    {
                        global::Player.main.SetPosition(gameData.storyStartLocation.position, Quaternion.Euler(gameData.storyStartLocation.rotation));
                    }
                    else
                    {
                        global::Player.main.SetPosition(gameData.creativeStartLocation.position, Quaternion.Euler(gameData.creativeStartLocation.rotation));
                    }
                }
            }

            return false;
        }
    }
}
