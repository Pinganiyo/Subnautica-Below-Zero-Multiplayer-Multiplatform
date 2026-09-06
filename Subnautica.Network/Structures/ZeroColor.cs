namespace Subnautica.Network.Structures
{
    using MessagePack;

    [MessagePackObject]
    public class ZeroColor
    {
        /**
         *
         * Renk (R)
         *
         
         *
         */
        [Key(0)]
        public float R { get; set; }

        /**
         *
         * Renk (G)
         *
         
         *
         */
        [Key(1)]
        public float G { get; set; }

        /**
         *
         * Renk (B)
         *
         
         *
         */
        [Key(2)]
        public float B { get; set; }

        /**
         *
         * Renk (Alpha)
         *
         
         *
         */
        [Key(3)]
        public float A { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroColor()
        {
        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public ZeroColor(float r, float g, float b, float a = 1)
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }

        /**
         *
         * Metin olarak bastırır.
         *
         
         *
         */
        public override string ToString()
        {
            return $"[ZeroColor: {this.R}, {this.G}, {this.B}, {this.A}]";
        }
    }
}
