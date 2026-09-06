namespace Subnautica.Network.Models.Server
{
    using System.Collections.Generic;
    
    using LiteNetLib;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class PlayerUpdatedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.PlayerUpdated;

        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.PlayerMovement;

        /**
         *
         * Packet Teslim Türü
         *
         
         *
         */
        [Key(2)]
        public override DeliveryMethod DeliveryMethod { get; set; } = DeliveryMethod.Unreliable;

        /**
         *
         * Sıkıştırılmış kamera açısı
         *
         
         *
         */
        [Key(5)]
        public short CompressedCameraPitch { get; set; }

        /**
         *
         * Nesne Pozisyonu
         *
         
         *
         */
        [Key(6)]
        public long CompressedPosition { get; set; }

        /**
         *
         * Nesne Açısı
         *
         
         *
         */
        [Key(7)]
        public long CompressedRotation { get; set; }


        /**
         *
         * Lokal Pozisyon
         *
         
         *
         */
        [Key(8)]
        public long CompressedLocalPosition { get; set; }

        /**
         *
         * CompressedRightHandItemRotation değeri
         *
         
         *
         */
        [Key(9)]
        public long CompressedRightHandItemRotation { get; set; }

        /**
         *
         * CompressedLeftHandItemRotation değeri
         *
         
         *
         */
        [Key(10)]
        public long CompressedLeftHandItemRotation { get; set; }

        /**
         *
         * HandItemComponent değeri
         *
         
         *
         */
        [Key(11)]
        public int CompressedCameraForward { get; set; }

        /**
         *
         * Oyuncu Elindeki Eşya
         *
         
         *
         */
        [Key(12)]
        public TechType ItemInHand { get; set; }

        /**
         *
         * SurfaceType değeri
         *
         
         *
         */
        [Key(13)]
        public VFXSurfaceTypes SurfaceType { get; set; }

        /**
         *
         * IsPrecursorArm değeri
         *
         
         *
         */
        [Key(14)]
        public bool IsPrecursorArm { get; set; }

        /**
         *
         * EmoteIndex değeri
         *
         
         *
         */
        [Key(15)]
        public byte EmoteIndex { get; set; }
        /**
         *
         * Ekipmanları barındırır.
         *
         
         *
         */
        [Key(16)]
        public List<TechType> Equipments { get; set; }

        /**
         *
         * HandItemComponent değeri
         *
         
         *
         */
        [Key(17)]
        public NetworkPlayerItemComponent HandItemComponent { get; set; }
    }
}