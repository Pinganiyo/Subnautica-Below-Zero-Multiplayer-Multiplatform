namespace Subnautica.Network.Extensions
{
    using LiteNetLib;
    using LiteNetLib.Utils;

    using Subnautica.Network.Core;
    using Subnautica.Network.Models.Core;

    public static class PacketExtensions
    {
        /**
         *
         * Packeti encode eder.
         *
         
         *
         */
        public static byte[] Serialize(this NetworkPacket packet)
        {
            return NetworkTools.Serialize(packet);
        }

        /**
         *
         * Paketi döner.
         *
         
         *
         */
        public static NetworkPacket GetPacket(this NetPacketReader reader)
        {
            return NetworkTools.Deserialize<NetworkPacket>(reader.GetRemainingBytesSegment());
        }

        /**
         *
         * Paketi döner.
         *
         
         *
         */
        public static NetworkPacket GetPacket(this NetDataReader reader)
        {
            return NetworkTools.Deserialize<NetworkPacket>(reader.GetRemainingBytesSegment());
        }
    }
}
