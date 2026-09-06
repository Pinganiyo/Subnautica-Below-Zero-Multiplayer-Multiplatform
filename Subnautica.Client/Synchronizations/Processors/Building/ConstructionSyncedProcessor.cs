namespace Subnautica.Client.Synchronizations.Processors.Building
{
    using Subnautica.Client.Abstracts;
    using Subnautica.Client.Core;
    using Subnautica.Events.EventArgs;
    using Subnautica.Network.Models.Core;
    using Subnautica.API.Enums;
    using Subnautica.API.Features;
    using Subnautica.Network.Core;

    using System.Collections;
    using System.Diagnostics;

    using UnityEngine;

    using ServerModel  = Subnautica.Network.Models.Server;
    using Construction = Subnautica.Client.Multiplayer.Constructing;

    public class ConstructionSyncedProcessor : NormalProcessor
    {
        /**
         *
         * Zamanlanmış veri gönderim durumu
         *
         
         *
         */
        private static bool IsSending { get; set; } = false;

        /**
         *
         * Gelen veriyi işler
         *
         
         *
         */
        public override bool OnDataReceived(NetworkPacket networkPacket)
        {
            return true;
        }

        /**
         *
         * Hayalet yapı kurulmaya çalışıldığında tetiklenir.
         *
         
         *
         */
        public static void OnConstructingGhostTryPlacing(ConstructionGhostTryPlacingEventArgs ev)
        {
            UpdateConstructionSync();
        }

        /**
         *
         * Yapı inşaası tamamlandığında tetiklenir.
         *
         
         *
         */
        public static void OnConstructingCompleted(ConstructionCompletedEventArgs ev)
        {
            UpdateConstructionSync();
        }

        /**
         *
         * Yapı yıkıldığında tetiklenir.
         *
         
         *
         */
        public static void OnConstructingRemoved(ConstructionRemovedEventArgs ev)
        {
            UpdateConstructionSync();
        }

        /**
         *
         * Yapı inşaa değeri değiştiğinde tetiklenir.
         *
         
         *
         */
        public static void UpdateConstructionSync()
        {
            if (Network.IsHost && !IsSending && !EventBlocker.IsEventBlocked(ProcessType.ConstructionSynced))
            {
                UWE.CoroutineHost.StartCoroutine(SendDataToServer());
            }
        }

        /**
         *
         * Zamanlanmış veriyi işler.
         *
         
         *
         */
        private static IEnumerator SendDataToServer()
        {
            IsSending = true;

            yield return new WaitForSecondsRealtime(0.1f);

            IsSending = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var serialized = Construction.Builder.SerializeGlobalRoot();
            NetworkServer.UpdateConstructionSync(serialized);

            stopwatch.Stop();

            Log.Info("SERIALIZED Time: " + stopwatch.ElapsedMilliseconds + ", Ticks: " + stopwatch.ElapsedTicks + ", Size: " + serialized.Length);
        }
    }
}
