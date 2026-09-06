namespace Subnautica.NetworkDebugger.Data
{
    using LiteNetLib;

    using Subnautica.API.Enums;

    public class NetworkDebuggerPacketLogItem
    {
        /**
         *
         * Boyut Nesnesi
         *
         
         *
         */
        public int Size { get; set; }

        /**
         *
         * Channel Nesnesi
         *
         
         *
         */
        public NetworkChannel Channel { get; set; }

        /**
         *
         * DeliveryMethod Nesnesi
         *
         
         *
         */
        public DeliveryMethod DeliveryMethod { get; set; }

        /**
         *
         * IsDownload Nesnesi
         *
         
         *
         */
        public bool IsDownload { get; set; }

        /**
         *
         * IsClient Nesnesi
         *
         
         *
         */
        public bool IsClient { get; set; }
    }
}
