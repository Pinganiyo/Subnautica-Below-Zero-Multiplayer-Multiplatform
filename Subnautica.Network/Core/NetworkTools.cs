namespace Subnautica.Network.Core
{
    using System;

    using MessagePack;

    public class NetworkTools
    {
        /**
         *
         * Veri şifreleme türünü barındırır.
         *
         
         *
         */
        private static MessagePackSerializerOptions mainCompression;

        /**
         *
         * Veri şifreleme türünü barındırır.
         *
         
         *
         */
        public static MessagePackSerializerOptions Lz4Compression 
        { 
            get
            {
                if (mainCompression == null)
                {
                    mainCompression = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4BlockArray);
                }

                return mainCompression;
            }
        }

        /**
         *
         * Veriyi encode eder.
         *
         
         *
         */
        public static byte[] Serialize<T>(T data)
        {
            return MessagePackSerializer.Serialize(data, Lz4Compression);
        }

        /**
         *
         * Veriyi decode eder.
         *
         
         *
         */
        public static T Deserialize<T>(ArraySegment<byte> data)
        {
            return MessagePackSerializer.Deserialize<T>(data, Lz4Compression);
        }

        /**
         *
         * Veriyi decode eder.
         *
         
         *
         */
        public static T Deserialize<T>(byte[] data)
        {
            return MessagePackSerializer.Deserialize<T>(data, Lz4Compression);
        }
    }
}