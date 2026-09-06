namespace Subnautica.Network.Models.Storage.World.Childrens
{
    using MessagePack;

    using Subnautica.API.Extensions;
    using Subnautica.API.Enums;
    using Subnautica.API.Features;
    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Structures;

    using UnityEngine;

    using WorldEntityModel = Subnautica.Network.Models.WorldEntity.DynamicEntityComponents;

    [MessagePackObject]
    public class WorldDynamicEntity
    {
        /**
         *
         * Yapı Kimliği değeri
         *
         
         *
         */
        [Key(0)]
        public ushort Id { get; set; }

        /**
         *
         * Item değeri
         *
         
         *
         */
        [Key(1)]
        public string UniqueId { get; set; }

        /**
         *
         * Üst Nesne Kimliği değeri
         *
         
         *
         */
        [Key(2)]
        public string ParentId { get; set; }

        /**
         *
         * Item değeri
         *
         
         *
         */
        [Key(3)]
        public byte[] Item { get; set; }

        /**
         *
         * TechType değeri
         *
         
         *
         */
        [Key(4)]
        public TechType TechType { get; set; }

        /**
         *
         * Position değeri
         *
         
         *
         */
        [Key(5)]
        public ZeroVector3 Position { get; set; }

        /**
         *
         * Rotation değeri
         *
         
         *
         */
        [Key(6)]
        public ZeroQuaternion Rotation { get; set; }

        /**
         *
         * AddedTime değeri
         *
         
         *
         */
        [Key(7)]
        public float AddedTime { get; set; }

        /**
         *
         * OwnershipId değeri
         *
         
         *
         */
        [Key(8)]
        public string OwnershipId { get; set; }

        /**
         *
         * IsDeployed değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsDeployed { get; set; }

        /**
         *
         * IsGlobalEntity değeri
         *
         
         *
         */
        [Key(10)]
        public bool IsGlobalEntity { get; set; }

        /**
         *
         * Component değeri
         *
         
         *
         */
        [Key(11)]
        public NetworkDynamicEntityComponent Component { get; set; }

        /**
         *
         * IsUsingByPlayer değeri
         *
         
         *
         */
        [IgnoreMember]
        public bool IsUsingByPlayer { get; set; }

        /**
         *
         * Velocity değeri
         *
         
         *
         */
        [IgnoreMember]
        public Vector3 Velocity;

        /**
         *
         * RotationVelocity değeri
         *
         
         *
         */
        [IgnoreMember]
        public Quaternion RotationVelocity;

        /**
         *
         * GameObject değeri
         *
         
         *
         */
        [IgnoreMember]
        public GameObject GameObject;

        /**
         *
         * Rigidbody değeri
         *
         
         *
         */
        [IgnoreMember]
        public Rigidbody Rigidbody;

        /**
         *
         * IsKinematic değeri
         *
         
         *
         */
        [IgnoreMember]
        public ZeroKinematicState KinematicState;

        /**
         *
         * LastPosition değeri
         *
         
         *
         */
        [IgnoreMember]
        private ZeroVector3 LastPosition;

        /**
         *
         * LastRotation değeri
         *
         
         *
         */
        [IgnoreMember]
        private ZeroQuaternion LastRotation;

        /**
         *
         * CurrentPosition değeri
         *
         
         *
         */
        [IgnoreMember]
        private Vector3 CurrentPosition;

        /**
         *
         * CurrentRotation değeri
         *
         
         *
         */
        [IgnoreMember]
        private Quaternion CurrentRotation;

        /**
         *
         * TeleportDistance değeri
         *
         
         *
         */
        [IgnoreMember]
        private float TeleportDistance = 100f;

        /**
         *
         * LiveMixin nesnesini döner.
         *
         
         *
         */
        public WorldEntityModel.Shared.LiveMixin GetLiveMixin()
        {
            if (this.Component is WorldEntityModel.SeaTruck)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruck>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.Exosuit)
            {
                return this.Component.GetComponent<WorldEntityModel.Exosuit>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.Hoverbike)
            {
                return this.Component.GetComponent<WorldEntityModel.Hoverbike>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SpyPenguin)
            {
                return this.Component.GetComponent<WorldEntityModel.SpyPenguin>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.MapRoomCamera)
            {
                return this.Component.GetComponent<WorldEntityModel.MapRoomCamera>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SeaTruckAquariumModule)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruckAquariumModule>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SeaTruckDockingModule)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruckDockingModule>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SeaTruckFabricatorModule)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruckFabricatorModule>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SeaTruckSleeperModule)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruckSleeperModule>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SeaTruckStorageModule)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruckStorageModule>().LiveMixin;
            }
            else if (this.Component is WorldEntityModel.SeaTruckTeleportationModule)
            {
                return this.Component.GetComponent<WorldEntityModel.SeaTruckTeleportationModule>().LiveMixin;
            }

            return null;
        }

        /**
         *
         * Bana ait olup olmadığını döner.
         *
         
         *
         */
        public bool IsMine(string playerId)
        {
            return this.OwnershipId == playerId;
        }

        /**
         *
         * Ebeveyni olup olmadığını döner.
         *
         
         *
         */
        public bool IsParentExist()
        {
            return !string.IsNullOrEmpty(this.ParentId);
        }

        /**
         *
         * Üst nesne değerini değiştirir.
         *
         
         *
         */
        public void SetParent(string parentId)
        {
            this.ParentId = parentId;
        }

        /**
         *
         * IsDeployed değerini değiştirir.
         *
         
         *
         */
        public void SetDeployed(bool isDeployed)
        {
            this.IsDeployed = isDeployed;
        }

        /**
         *
         * Position değerini değiştirir.
         *
         
         *
         */
        public void SetPosition(ZeroVector3 position)
        {
            this.Position = position;
        }

        /**
         *
         * Position ve Rotation değerini değiştirir.
         *
         
         *
         */
        public void SetPositionAndRotation(ZeroVector3 position, ZeroQuaternion rotation)
        {
            this.Position = position;
            this.Rotation = rotation;
        }

        /**
         *
         * Sahibi Değiştirir
         *
         
         *
         */
        public void SetOwnership(string ownershipId)
        {
            this.OwnershipId = ownershipId;
        }

        /**
         *
         * Kinematic durumunu önbelleğe alır.
         *
         
         *
         */
        public void CacheKinematicStatus()
        {
            if (this.Rigidbody)
            {
                this.KinematicState = this.Rigidbody.isKinematic ? ZeroKinematicState.Kinematic : ZeroKinematicState.NonKinematic;
            }
        }

        /**
         *
         * Component değerini değiştirir.
         *
         
         *
         */
        public WorldDynamicEntity SetComponent(NetworkDynamicEntityComponent component)
        {
            this.Component = component;
            return this;
        }

        /**
         *
         * Nesne görünür mü?
         *
         
         *
         */
        public bool IsVisible(ZeroVector3 playerPosition)
        {
            return this.Position.Distance(playerPosition) < Network.DynamicEntity.VisibilityDistance;
        }

        /**
         *
         * Fizik simülasyonu yapılabilir mi?
         *
         
         *
         */
        public bool IsPhysicSimulateable(ZeroVector3 playerPosition)
        {
            return this.Position.Distance(playerPosition) < Network.DynamicEntity.PhysicsDistance;
        }

        /**
         *
         * GameObject'i günceller.
         *
         
         *
         */
        public void UpdateGameObject()
        {
            if (this.GameObject == null)
            {
                this.GameObject = Network.Identifier.GetGameObject(this.UniqueId, true);

                if (this.GameObject)
                {
                    this.Rigidbody = this.GameObject.GetComponent<Rigidbody>();
                }
            }

            if (this.GameObject == null)
            {
                Log.Error("NOT FOUND Entity ==> " + this.TechType + ", UniqueId: " + this.UniqueId);
            }
        }

        /**
         *
         * Nesneye enterpolasyon yapar.
         *
         
         *
         */
        public void Interpolate()
        {
            this.UpdateGameObject();

            if (this.GameObject)
            {
                if (this.Position != this.LastPosition)
                {
                    this.LastPosition    = this.Position;
                    this.CurrentPosition = this.Position.ToVector3();
                }

                if (this.Rotation != this.LastRotation)
                {
                    this.LastRotation    = this.Rotation;
                    this.CurrentRotation = this.Rotation.ToQuaternion();
                }

                if (ZeroVector3.Distance(this.GameObject.transform.position, this.CurrentPosition) > this.TeleportDistance)
                {
                    this.GameObject.transform.position = this.CurrentPosition;
                    this.GameObject.transform.rotation = this.CurrentRotation;
                }
                else
                {
                    this.GameObject.transform.position = Vector3.SmoothDamp(this.GameObject.transform.position, this.CurrentPosition, ref this.Velocity, 0.3f);
                    this.GameObject.transform.rotation = BroadcastInterval.QuaternionSmoothDamp(this.GameObject.transform.rotation, this.CurrentRotation, ref this.RotationVelocity, 0.3f);
                }
            }
        }
    }

    [MessagePackObject]
    public class WorldDynamicEntityPosition
    {
        /**
         *
         * Yapı Kimliği değeri
         *
         
         *
         */
        [Key(0)]
        public ushort Id { get; set; }

        /**
         *
         * Position değeri
         *
         
         *
         */
        [Key(1)]
        public long Position { get; set; }

        /**
         *
         * Rotation değeri
         *
         
         *
         */
        [Key(2)]
        public long Rotation { get; set; }
    }
}