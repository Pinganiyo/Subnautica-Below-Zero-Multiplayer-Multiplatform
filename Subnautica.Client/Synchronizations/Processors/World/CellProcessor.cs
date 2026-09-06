namespace Subnautica.Client.Synchronizations.Processors.World
{
    using Subnautica.Network.Models.Core;
    using Subnautica.Client.Abstracts;
    using Subnautica.API.Features;

    using Subnautica.Events.EventArgs;

    public class CellProcessor : NormalProcessor
    {
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
         * Cell yüklendikten sonra tetiklenir.
         *
         
         *
         */
        public static void OnCellLoading(CellLoadingEventArgs ev)
        {
            Network.CellManager.SetLoaded(ev.BatchId, ev.CellId, true);
        }

        /**
         *
         * Cell kaldırılırken tetiklenir.
         *
         
         *
         */
        public static void OnCellUnLoading(CellUnLoadingEventArgs ev)
        {
            Network.CellManager.SetLoaded(ev.BatchId, ev.CellId, false);
        }
    }
}
