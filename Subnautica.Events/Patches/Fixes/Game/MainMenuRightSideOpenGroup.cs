namespace Subnautica.Events.Patches.Fixes.Game
{
    using HarmonyLib;
    using UnityEngine;

    [HarmonyPatch(typeof(MainMenuRightSide), nameof(MainMenuRightSide.OpenGroup))]
    public static class MainMenuRightSideOpenGroup
    {
        private static bool Prefix(MainMenuRightSide __instance, ref string target)
        {
            if (target == "NewGame")
            {
                var hostGroup = GameObject.Find("MultiplayerHostBase");
                if (hostGroup != null && hostGroup.activeSelf)
                {
                    target = "MultiplayerHostBase";
                }
            }

            return true;
        }
    }
}
