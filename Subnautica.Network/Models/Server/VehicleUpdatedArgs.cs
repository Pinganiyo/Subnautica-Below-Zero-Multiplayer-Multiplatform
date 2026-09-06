using Subnautica.Network.Models.Server;

namespace Subnautica.Network.Models.Server
{
    using System;
    using System.Collections.Generic;

    using LiteNetLib;

    using MessagePack;

    using Subnautica.API.Enums;
    using Subnautica.Network.Models.Core;
    using Subnautica.Network.Structures;

    [MessagePackObject]
    public class VehicleUpdatedArgs : NetworkPacket
    {
        /**
         *
         * Ağ Paket Türü
         *
         
         *
         */
        [Key(0)]
        public override ProcessType Type { get; set; } = ProcessType.VehicleUpdated;

        /**
         *
         * Packet Kanal Türü
         *
         
         *
         */
        [Key(1)]
        public override NetworkChannel ChannelType { get; set; } = NetworkChannel.VehicleMovement;

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
         * Oyuncu id numarasını barındırır.
         *
         
         *
         */
        [Key(5)]
        public byte PlayerId { get; set; }

        /**
         *
         * Araç id numarasını barındırır.
         *
         
         *
         */
        [Key(6)]
        public ushort EntityId { get; set; }

        /**
         *
         * Nesne Pozisyonu
         *
         
         *
         */
        [Key(7)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Nesne Açısı
         *
         
         *
         */
        [Key(8)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * Nesne Açısı
         *
         
         *
         */
        [Key(9)]
        public VehicleUpdateComponent Component { get; set; }
    }

    [Union(0, typeof(ExosuitUpdateComponent))]
    [Union(1, typeof(SpyPenguinUpdateComponent))]
    [Union(2, typeof(HoverbikeUpdateComponent))]
    [MessagePackObject]
    public abstract class VehicleUpdateComponent
    {
        /**
         *
         * Yeni Veri mi?
         *
         
         *
         */
        [IgnoreMember]
        public bool IsNew { get; set; }

        /**
         *
         * Komponenti döner.
         *
         
         *
         */
        public T GetComponent<T>()
        {
            if (this is T)
            {
                return (T)Convert.ChangeType(this, typeof(T));
            }

            return default(T);
        }
    }

    [Union(0, typeof(ExosuitDrillArmComponent))]
    [Union(1, typeof(ExosuitGrapplingArmComponent))]
    [Union(2, typeof(ExosuitClawArmComponent))]
    [MessagePackObject]
    public abstract class ExosuitArmComponent
    {
        /**
         *
         * Komponenti döner.
         *
         
         *
         */
        public T GetComponent<T>()
        {
            if (this is T)
            {
                return (T)Convert.ChangeType(this, typeof(T));
            }

            return default(T);
        }
    }

    [MessagePackObject]
    public class ExosuitUpdateComponent : VehicleUpdateComponent
    {
        /**
         *
         * IsOnGround Değeri
         *
         
         *
         */
        [Key(0)]
        public bool IsOnGround { get; set; }

        /**
         *
         * CameraPosition değeri
         *
         
         *
         */
        [Key(1)]
        public ZeroVector3 CameraPosition { get; set; }

        /**
         *
         * AngleX değeri
         *
         
         *
         */
        [Key(2)]
        public float AngleX { get; set; }

        /**
         *
         * IsPlayingJumpSound değeri
         *
         
         *
         */
        [Key(3)]
        public bool IsPlayingJumpSound { get; set; }

        /**
         *
         * IsPlayingBoostSound değeri
         *
         
         *
         */
        [Key(4)]
        public bool IsPlayingBoostSound { get; set; }

        /**
         *
         * LeftArm değeri
         *
         
         *
         */
        [Key(5)]
        public ExosuitArmComponent LeftArm { get; set; }

        /**
         *
         * RightArm değeri
         *
         
         *
         */
        [Key(6)]
        public ExosuitArmComponent RightArm { get; set; }
    }

    [MessagePackObject]
    public class SpyPenguinUpdateComponent : VehicleUpdateComponent
    {
        /**
         *
         * IsDrilling Değeri
         *
         
         *
         */
        [Key(0)]
        public bool IsSelfieMode { get; set; }

        /**
         *
         * SelfieNumber Değeri
         *
         
         *
         */
        [Key(1)]
        public float SelfieNumber { get; set; }

        /**
         *
         * Animations Değeri
         *
         
         *
         */
        [Key(2)]
        public List<string> Animations { get; set; }
    }

    [MessagePackObject]
    public class HoverbikeUpdateComponent : VehicleUpdateComponent
    {
        /**
         *
         * IsJumping Değeri
         *
         
         *
         */
        [Key(0)]
        public bool IsJumping { get; set; }

        /**
         *
         * IsBoosting Değeri
         *
         
         *
         */
        [Key(1)]
        public bool IsBoosting { get; set; }
    }

    [MessagePackObject]
    public class ExosuitDrillArmComponent : ExosuitArmComponent
    {
        /**
         *
         * IsDrilling Değeri
         *
         
         *
         */
        [Key(0)]
        public bool IsDrilling { get; set; }

        /**
         *
         * IsDrilling Değeri
         *
         
         *
         */
        [Key(1)]
        public bool IsFxPlaying { get; set; }
    }

    [MessagePackObject]
    public class ExosuitClawArmComponent : ExosuitArmComponent
    {
        /**
         *
         * IsBash Değeri
         *
         
         *
         */
        [Key(0)]
        public bool IsBash { get; set; }

        /**
         *
         * IsPickup Değeri
         *
         
         *
         */
        [Key(1)]
        public bool IsPickup { get; set; }

        /**
         *
         * IsUsing Değeri
         *
         
         *
         */
        [Key(2)]
        public bool IsUsing { get; set; }
    }

    [MessagePackObject]
    public class ExosuitGrapplingArmComponent : ExosuitArmComponent
    {
        /**
         *
         * HookPosition Değeri
         *
         
         *
         */
        [Key(0)]
        public ZeroVector3 HookPosition { get; set; }

        /**
         *
         * HookRotation Değeri
         *
         
         *
         */
        [Key(1)]
        public ZeroQuaternion HookRotation { get; set; }

        /**
         *
         * IsFlying Değeri
         *
         
         *
         */
        [Key(2)]
        public bool IsFlying { get; set; }

        /**
         *
         * IsAttached Değeri
         *
         
         *
         */
        [Key(3)]
        public bool IsAttached { get; set; }

        /**
         *
         * IsUsing Değeri
         *
         
         *
         */
        [Key(4)]
        public bool IsUsing { get; set; }

        /**
         *
         * IsStopped Değeri
         *
         
         *
         */
        [Key(5)]
        public bool IsStopped { get; set; }
    }
}