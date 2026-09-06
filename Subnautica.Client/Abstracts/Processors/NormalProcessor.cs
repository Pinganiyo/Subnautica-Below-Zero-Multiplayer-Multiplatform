namespace Subnautica.Client.Abstracts
{
    using Subnautica.Network.Models.Core;

    public abstract class NormalProcessor : BaseProcessor
    {

        /**
         *
         * Gelen veriyi işler
         *
         
         *
         */
        public abstract bool OnDataReceived(NetworkPacket networkPacket);
    }
}
