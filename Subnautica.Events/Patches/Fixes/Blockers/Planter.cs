namespace Subnautica.Events.Patches.Fixes.Blockers
{
    using System.Collections.Generic;

    using HarmonyLib;

    using Subnautica.API.Features;

    [HarmonyPatch(typeof(global::Planter), nameof(global::Planter.ReplaceItem))]
    public static class Planter
    {
        /**
         *
         * Bloklanmış olayı barındırır.
         *
         
         *
         */
        private static List<EventBlocker> Blockers = new List<EventBlocker>();

        /**
         *
         * Fonksiyonu yamalar.
         *
         
         *
         */
        private static void Prefix()
        {
            if (Network.IsMultiplayerActive)
            {
                foreach (var techType in TechGroup.Planters)
                {
                    Blockers.Add(EventBlocker.Create(techType));
                }
            }
        }

        /**
         *
         * Fonksiyonu yamalar.
         *
         
         *
         */
        private static void Postfix()
        {
            if (Blockers.Count > 0)
            {
                foreach (var blocker in Blockers)
                {
                    blocker.Dispose();
                }

                Blockers.Clear();
            }
        }
    }
}
