namespace Subnautica.Network.Structures
{
    using System;

    using MessagePack;

    [MessagePackObject]
    public class ZeroQuaternion : IEquatable<ZeroQuaternion>
    {
        /**
         *
         * Açı (X)
         *
         
         *
         */
        [Key(0)]
        public float X;

        /**
         *
         * Açı (Y)
         *
         
         *
         */
        [Key(1)]
        public float Y;

        /**
         *
         * Açı (Z)
         *
         
         *
         */
        [Key(2)]
        public float Z;

        /**
         *
         * Açı (W)
         *
         
         *
         */
        [Key(3)]
        public float W;

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroQuaternion()
        {
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroQuaternion(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        /**
         *
         * Karşılaştırma işlemi yapar.
         *
         
         *
         */
        public static bool operator ==(ZeroQuaternion u, ZeroQuaternion v)
        {
            if (u is null && v is null)
            {
                return true;
            }

            return u is ZeroQuaternion && u.Equals(v);
        }

        /**
         *
         * Karşılaştırma işlemi yapar.
         *
         
         *
         */
        public static bool operator !=(ZeroQuaternion u, ZeroQuaternion v)
        {
            return !(u == v);
        }

        /**
         *
         * Eşitlik işlemi yapar.
         *
         
         *
         */
        public bool Equals(ZeroQuaternion other)
        {
            if (other is null)
            {
                return false;
            }

            return other.X == this.X && other.Y == this.Y && other.Z == this.Z && other.W == this.W;
        }

        /**
         *
         * Eşitlik işlemi yapar.
         *
         
         *
         */
        public override bool Equals(object obj)
        {
            return obj is ZeroQuaternion other && this.Equals(other);
        }

        /**
         *
         * Sayısal değeri döner.
         *
         
         *
         */
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 0;
                hash = (hash * 397) ^ this.X.GetHashCode();
                hash = (hash * 397) ^ this.Y.GetHashCode();
                hash = (hash * 397) ^ this.Z.GetHashCode();
                hash = (hash * 397) ^ this.W.GetHashCode();

                return hash;
            }
        }

        /**
         *
         * Metin olarak bastırır.
         *
         
         *
         */
        public override string ToString()
        {
            return $"[ZeroQuaternion: {this.X}, {this.Y}, {this.Z}, {this.W}]";
        }
    }
}
