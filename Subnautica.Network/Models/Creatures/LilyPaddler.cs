namespace Subnautica.Network.Models.Creatures
{
    using MessagePack;

    using Subnautica.Network.Core.Components;

    [MessagePackObject]
    public class LilyPaddler : NetworkCreatureComponent
    {
        /**
         *
         * TargetId değerini barındırır.
         *
         
         *
         */
        [Key(0)]
        public byte TargetId { get; set; }

        /**
         *
         * LastHypnotizeTime değerini barındırır.
         *
         
         *
         */
        [Key(1)]
        public float LastHypnotizeTime { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public LilyPaddler()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public LilyPaddler(byte targetId)
        {
            this.TargetId = targetId;
        }
    }
}