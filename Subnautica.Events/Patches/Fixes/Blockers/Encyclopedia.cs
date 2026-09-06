namespace Subnautica.Events.Patches.Fixes.Encyclopedia
{
    using HarmonyLib;

    using Subnautica.API.Enums;
    using Subnautica.API.Features;

    [HarmonyPatch(typeof(PDAEncyclopedia), nameof(PDAEncyclopedia.Initialize))]
    public static class Encyclopedia
    {
        /**
         *
         * Bloklanmış olayı barındırır.
         *
         
         *
         */
        private static EventBlocker Blocker = null;

        /**
         *
         * Fonksiyonu yamalar.
         *
         
         *
         */
        private static void Prefix(PDAData pdaData)
        {
            if(Network.IsMultiplayerActive)
            {
                Blocker = EventBlocker.Create(ProcessType.EncyclopediaAdded);
            }
        }

        /**
         *
         * Fonksiyonu yamalar.
         *
         
         *
         */
        private static void Postfix(PDAData pdaData)
        {
            if (Blocker != null)
            {
                Blocker.Dispose();
            }
        }
    }
}
