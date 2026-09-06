namespace Subnautica.Network.Models.Storage.Construction
{
    using System;

    using MessagePack;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Structures;
    using Subnautica.Network.Models.WorldEntity.DynamicEntityComponents.Shared;


    [MessagePackObject]
    public class ConstructionItem
    {
        /**
         *
         * Yapı Index Kimliği
         *
         
         *
         */
        [Key(0)]
        public uint Id { get; set; }

        /**
         *
         * Yapı Kimliği
         *
         
         *
         */
        [Key(1)]
        public string UniqueId { get; set; }

        /**
         *
         * Base Kimliği
         *
         
         *
         */
        [Key(2)]
        public string BaseId { get; set; }

        /**
         *
         * Teknoloji Türü
         *
         
         *
         */
        [Key(3)]
        public TechType TechType { get; set; }

        /**
         *
         * LastRotation Türü
         *
         
         *
         */
        [Key(4)]
        public int LastRotation { get; set; }

        /**
         *
         * Yapı pozisyon barındırır.
         *
         
         *
         */
        [Key(5)]
        public ZeroVector3 PlacePosition { get; set; }

        /**
         *
         * CellPosition Değeri
         *
         
         *
         */
        [Key(6)]
        public ZeroVector3 CellPosition { get; set; }

        /**
         *
         * FaceLocalPosition Değeri
         *
         
         *
         */
        [Key(7)]
        public ZeroVector3 LocalPosition { get; set; }

        /**
         *
         * FaceLocalRotation Değeri
         *
         
         *
         */
        [Key(8)]
        public ZeroQuaternion LocalRotation { get; set; }

        /**
         *
         * IsFaceHasValue Değeri
         *
         
         *
         */
        [Key(9)]
        public bool IsFaceHasValue { get; set; }

        /**
         *
         * FaceDirection Değeri
         *
         
         *
         */
        [Key(10)]
        public Base.Direction FaceDirection { get; set; }

        /**
         *
         * FaceType Değeri
         *
         
         *
         */
        [Key(11)]
        public Base.FaceType FaceType { get; set; }

        /**
         *
         * Tamamlanma Oranı
         *
         
         *
         */
        [Key(12)]
        public float ConstructedAmount { get; set; }

        /**
         *
         * Base Türü mü?
         *
         
         *
         */
        [Key(13)]
        public bool IsBasePiece { get; set; }

        /**
         *
         * Statik Nesne mi?
         *
         
         *
         */
        [Key(14)]
        public bool IsStatic { get; set; }

        /**
         *
         * Metadata verisi
         *
         
         *
         */
        [Key(15)]
        public MetadataComponent Component { get; set; }

        /**
         *
         * LiveMixin verisi
         *
         
         *
         */
        [Key(16)]
        public LiveMixin LiveMixin { get; set; }

        /**
         *
         * İnşa edilmiş mi?
         *
         
         *
         */
        public bool IsConstructed()
        {
            return this.ConstructedAmount >= 1f;
        }

        /**
         *
         * Statik nesne oluşturur.
         *
         
         *
         */
        public static ConstructionItem CreateStaticItem(string uniqueId, TechType techType)
        {
            return new ConstructionItem()
            {
                IsStatic          = true,
                UniqueId          = uniqueId,
                TechType          = techType,
                ConstructedAmount = 1f,
            };
        }

        /**
         *
         * Component yok ise ekler, var ise döner.
         *
         
         *
         */
        public T EnsureComponent<T>()
        {
            if(this.Component == null)
            {
                this.Component = (MetadataComponent) Activator.CreateInstance(typeof(T));
            }

            return this.Component.GetComponent<T>();
        }
    }
}
