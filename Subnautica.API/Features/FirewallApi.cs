namespace Subnautica.API.Features
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features.Helper;

    public class FirewallApi
    {
        /**
         *
         * IsInitialized değerini barındırır.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        private static bool IsInitialized { get; set; } = true;

        /**
         *
         * Son çıktıyı barındırır.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static string LastOutput { get; private set; } = "";

        /**
         *
         * Son hatayı barındırır.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static string LastError { get; private set; } = "";

        /**
         *
         * SubnauticaBelowZeroDescription değerini barındırır.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        private static string SubnauticaBelowZeroDescription { get; set; } = "Subnautica BZ Multiplayer by BOT Benson";

        /**
         *
         * SubnauticaBelowZeroId değerini barındırır.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        private static string SubnauticaBelowZeroId { get; set; } = "subnauticazero";

        /**
         *
         * Subnautica Firewall Kurulumunu yapar.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static void SetupFirewallWithAdminPerms(string filePath)
        {
        }

        /**
         *
         * Subnautica Firewall Kurulumunu yapar.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static void SetupSubnauticaFirewall(string filePath)
        {
        }

        /**
         *
         * Kurallar doğru yapılandırılmış mı?
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static bool IsSubnauticaFirewallOk(string path)
        {
            return true;
        }

        /**
         *
         * Subnautica Kuralları döner.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static List<FirewallItemFormat> GetSubnauticaRules()
        {
            return GetRules(FirewallApi.SubnauticaBelowZeroId);
        }

        /**
         *
         * Kuralları döner.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public static List<FirewallItemFormat> GetRules(string name)
        {
            var items = new List<FirewallItemFormat>();
            return items;
        }

        /**
         *
         * komut çalıştırır.
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        private static void ExecuteCommand(string command, bool useCorePath = false, bool isNetShCommand = true, bool silence = true)
        {
            try
            {
                var process = new System.Diagnostics.Process();

                if (isNetShCommand)
                {
                    process.StartInfo.FileName  = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "netsh.exe");
                    process.StartInfo.Arguments = command;
                }
                else
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = string.Format("/c {0}", command);
                }

                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError  = true;
                process.StartInfo.UseShellExecute = false;

                if (silence)
                {
                    process.StartInfo.WindowStyle    = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                }

                if (useCorePath)
                {
                    process.StartInfo.WorkingDirectory = Paths.GetLauncherGameCorePath();
                }

                process.Start();

                var strOutput = process.StandardOutput.ReadToEnd();
                var strError  = process.StandardError.ReadToEnd();

                process.WaitForExit(5000);

                LastOutput = strOutput?.Trim();
                LastError  = strError?.Trim();
            }
            catch (Exception ex)
            {
                LastOutput = "";
                LastError = $"System.Exception: {ex.Message}:{ex.InnerException}";
            }

            if (LastError.IsNotNull())
            {
                Log.Error($"FirewallApi Exception: {LastError}, SC: " + silence);
            }
        }
    }
}
