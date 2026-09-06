namespace Subnautica.API.Features.NetworkUtility
{
    using System.Linq;

    using Subnautica.Network.Core.Components;
    using Subnautica.Network.Models.Client;
    using Subnautica.Network.Models.Storage.World.Childrens;

    public class Session
    {
        /**
         *
         * Sunucu verilerini barındırır.
         *
         
         *
         */
        public JoiningServerArgs Current { get; private set; }

        /**
         *
         * EndGameWorldTime değerini barındırır.
         *
         
         *
         */
        public double EndGameWorldTime { get; private set; }

        /**
         *
         * Oyuncu seatruck içerisinde mi?
         *
         
         *
         */
        public bool IsInSeaTruck { get; set; }

        /**
         *
         * Sunucu verilerini günceller.
         *
         
         *
         */
        public void SetSession(JoiningServerArgs session)
        {
            this.Current = session;
        }

        /**
         *
         * Keşfeldilmiş teknoloji ekler.
         *
         
         *
         */
        public void AddDiscoveredTechType(TechType techType)
        {
            this.Current.DiscoveredTechTypes.Add(techType);
        }

        /**
         *
         * Brinicle değerini döner.
         *
         
         *
         */
        public Brinicle GetBrinicle(string uniqueId)
        {
            return this.Current.Brinicles.FirstOrDefault(q => q.UniqueId == uniqueId);
        }

        /**
         *
         * Brinicle değerini günceller.
         *
         
         *
         */
        public void SetBrinicle(Brinicle brinicle)
        {
            this.Current.Brinicles.RemoveWhere(q => q.UniqueId == brinicle.UniqueId);
            this.Current.Brinicles.Add(brinicle);
        }

        /**
         *
         * Brinicle var olup olmadığına bakar.
         *
         
         *
         */
        public bool IsBrinicleExists(string uniqueId)
        {
            return this.Current.Brinicles.Any(q => q.UniqueId == uniqueId);
        }

        /**
         *
         * CosmeticItem var olup olmadığına bakar.
         *
         
         *
         */
        public bool IsCosmeticItemExists(string uniqueId)
        {
            return this.Current.CosmeticItems.Any(q => q.StorageItem.ItemId == uniqueId);
        }

        /**
         *
         * Cosmetic Item nesnesini değiştirir
         *
         
         *
         */
        public void SetCosmeticItem(CosmeticItem cosmeticItem)
        {
            this.Current.CosmeticItems.RemoveWhere(q => q.StorageItem.ItemId == cosmeticItem.StorageItem.ItemId);
            this.Current.CosmeticItems.Add(cosmeticItem);
        }

        /**
         *
         * Cosmetic Item nesnesini değiştirir
         *
         
         *
         */
        public void RemoveCosmeticItem(string uniqueId)
        {
            this.Current.CosmeticItems.RemoveWhere(q => q.StorageItem.ItemId == uniqueId);
        }

        /**
         *
         * Sunucu verilerini günceller.
         *
         
         *
         */
        public bool SetConstructionComponent(string uniqueId, MetadataComponent component)
        {
            var construction = this.Current.Constructions.FirstOrDefault(q => q.UniqueId == uniqueId);
            if (construction == null)
            {
                return false;
            }

            construction.Component = component;
            return true;
        }

        /**
         *
         * Oyun zamanını döner.
         *
         
         *
         */
        public double GetWorldTime()
        {
            if (BelowZeroEndGame.isActive)
            {
                return this.EndGameWorldTime;
            }

            return DayNightCycle.main.timePassedAsDouble;
        }

        /**
         *
         * Oyun sonu zamanını değiştirir
         *
         
         *
         */
        public void SetEndGameWorldTime(double time, bool isAdd = false)
        {
            if (isAdd)
            {
                this.EndGameWorldTime += time;
            }
            else
            {
                this.EndGameWorldTime = time;
            }
        }

        /**
         *
         * Bütün verileri temizler.
         *
         
         *
         */
        public void Dispose()
        {
            this.Current      = null;
            this.IsInSeaTruck = false;
        }
    }
}
