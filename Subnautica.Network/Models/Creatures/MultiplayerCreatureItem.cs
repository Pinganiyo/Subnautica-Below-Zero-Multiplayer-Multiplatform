namespace Subnautica.Network.Models.Creatures
{
    using MessagePack;

    using Subnautica.API.Features;
    using Subnautica.API.Extensions;
    using Subnautica.API.Features.Creatures.Datas;
    using Subnautica.Network.Structures;
    using Subnautica.Network.Models.Server;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;
    using Subnautica.Network.Models.Core;
    using Subnautica.API.Enums;

    [MessagePackObject]
    public class MultiplayerCreatureItem
    {
        /**
         *
         * OwnerId Değerini Barındırır.
         *
         
         *
         */
        [Key(0)]
        public byte OwnerId { get; set; }

        /**
         *
         * Id Değerini Barındırır.
         *
         
         *
         */
        [Key(1)]
        public ushort Id { get; set; }

        /**
         *
         * LeashPosition Değerini Barındırır.
         *
         
         *
         */
        [Key(2)]
        public ZeroVector3 LeashPosition { get; set; }

        /**
         *
         * LeashRotation Değerini Barındırır.
         *
         
         *
         */
        [Key(3)]
        public ZeroQuaternion LeashRotation { get; set; }

        /**
         *
         * TechType sınıfını barındırır.
         *
         
         *
         */
        [Key(4)]
        public TechType TechType { get; set; }

        /**
         *
         * LiveMixin sınıfını barındırır.
         *
         
         *
         */
        [Key(5)]
        public LiveMixin LiveMixin { get; set; }

        /**
         *
         * Position barındırır.
         *
         
         *
         */
        [IgnoreMember]
        public ZeroVector3 Position { get; private set; }

        /**
         *
         * Rotation barındırır.
         *
         
         *
         */
        [IgnoreMember]
        public ZeroQuaternion Rotation { get; private set; }

        /**
         *
         * CellId değeri
         *
         
         *
         */
        [IgnoreMember]
        public ZeroInt3 CellId { get; private set; }

        /**
         *
         * WorldStreamerId Değeri
         *
         
         *
         */
        [IgnoreMember]
        public string WorldStreamerId { get; private set; }

        /**
         *
         * BusyOwnerId Değeri
         *
         
         *
         */
        [IgnoreMember]
        public byte BusyOwnerId { get; private set; }

        /**
         *
         * IsCreatureBusy Değeri
         *
         
         *
         */
        [IgnoreMember]
        private bool IsCreatureBusy { get; set; }

        /**
         *
         * LastActionPacket Değeri
         *
         
         *
         */
        [IgnoreMember]
        private NetworkPacket ActionPacket { get; set; }

        /**
         *
         * Data Değeri
         *
         
         *
         */
        [IgnoreMember]
        public BaseCreatureData Data { get; private set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public MultiplayerCreatureItem()
        {

        }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public MultiplayerCreatureItem(byte ownerId, ushort id, ZeroVector3 position, ZeroQuaternion rotation, TechType techType)
        {
            this.OwnerId       = ownerId;
            this.Id            = id;
            this.LeashPosition = position;
            this.LeashRotation = rotation;
            this.TechType      = techType;
            this.Data          = this.TechType.GetCreatureData();
            this.LiveMixin     = new LiveMixin(this.Data.Health, this.Data.Health);
        }

        /**
         *
         * Yaratık sahibini değiştirir.
         *
         
         *
         */
        public void SetOwnership(byte ownershipId)
        {
            this.OwnerId = ownershipId;
        }

        /**
         *
         * WorldStreamerId değerini değiştirir
         *
         
         *
         */
        public void SetWorldStreamerId(string worldStreamerId)
        {
            this.WorldStreamerId = worldStreamerId;
        }

        /**
         *
         * Son aksiyon paketini barındırır.
         *
         
         *
         */
        public void SetAction(NetworkPacket lastAction, byte busyOwnerId = 0)
        {
            this.ActionPacket = lastAction;

            if (busyOwnerId != 0)
            {
                this.SetBusyOwnerId(busyOwnerId);
            }
        }

        /**
         *
         * Meşgul eden oyuncu id değiştirir.
         *
         
         *
         */
        public void SetBusyOwnerId(byte ownerId)
        {
            this.BusyOwnerId = ownerId;
        }

        /**
         *
         * Meşgul durumunu ayarlar.
         *
         
         *
         */
        public void SetBusy(bool isBusy)
        {
            this.IsCreatureBusy = isBusy;
        }

        /**
         *
         * Meşgul eden oyuncu id temizler
         *
         
         *
         */
        public void ClearBusyOwnerId()
        {
            this.BusyOwnerId = 0;
        }

        /**
         *
         * Son aksiyon paketini temizler
         *
         
         *
         */
        public void ClearAction(bool clearBusyOwner)
        {
            this.ActionPacket = null;

            if (clearBusyOwner)
            {
                this.ClearBusyOwnerId();
            }
        }

        /**
         *
         * Yeni konumu ve açıyı değiştirir.
         *
         
         *
         */
        public void SetPositionAndRotation(ZeroVector3 position, ZeroQuaternion rotation)
        {
            this.SetPosition(position);
            this.SetRotation(rotation);
        }

        /**
         *
         * Yeni konumu değiştirir.
         *
         
         *
         */
        public void SetPosition(ZeroVector3 position)
        {
            this.Position = position;
        }

        /**
         *
         * Yeni açıyı değiştirir.
         *
         
         *
         */
        public void SetRotation(ZeroQuaternion rotation)
        {
            this.Rotation = rotation;
        }

        /**
         *
         * Yeni hücre konumunu değiştirir.
         *
         
         *
         */
        public void SetCellId(ZeroInt3 cellId)
        {
            this.CellId = cellId;
        }
        
        /**
         *
         * Son Olayı döner.
         *
         
         *
         */
        public NetworkPacket GetAction()
        {
            return this.ActionPacket;
        }
        
        /**
         *
         * Son Olay türünü döner.
         *
         
         *
         */
        public ProcessType GetActionType()
        {
            return this.ActionPacket != null ? this.ActionPacket.Type : ProcessType.None;
        }

        /**
         *
         * Aksiyon mevcut mu?
         *
         
         *
         */
        public bool IsActionExists()
        {
            return this.GetAction() != null;
        }

        /**
         *
         * Meşgul mü?
         *
         
         *
         */
        public bool IsBusy()
        {
            return this.BusyOwnerId != 0 || this.IsCreatureBusy;
        }

        /**
         *
         * Donmuş mu?
         *
         
         *
         */
        public bool IsFrozen()
        {
            return this.GetActionType() is CreatureFreezeArgs;
        }

        /**
         *
         * Yaratık sahibini kontrol eder.
         *
         
         *
         */
        public bool IsNotMine(byte ownershipId = 0)
        {
            return !this.IsMine(ownershipId);
        }

        /**
         *
         * Yaratık sahibini kontrol eder.
         *
         
         *
         */
        public bool IsMine(byte ownershipId = 0)
        {
            if (ownershipId == 0)
            {
                return this.OwnerId == ZeroPlayer.CurrentPlayer.PlayerId;
            }

            return this.OwnerId == ownershipId;
        }

        /**
         *
         * Yaratık sahibi var mı?
         *
         
         *
         */
        public bool IsExistsOwnership()
        {
            return this.OwnerId != 0;
        }
    }
}
