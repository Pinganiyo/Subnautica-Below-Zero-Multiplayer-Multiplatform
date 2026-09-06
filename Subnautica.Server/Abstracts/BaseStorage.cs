namespace Subnautica.Server.Abstracts
{
    using System;
    using System.IO;

    using Subnautica.API.Extensions;
    using Subnautica.API.Features;
    using Subnautica.Network.Core;

    public abstract class BaseStorage
    {   /**
         *
         * Multi Thread Kilidi
         *
         
         *
         */
        public object ProcessLock { get; set; } = new object();

        /**
         *
         * Sunucu id numarasını barındırır.
         *
         
         *
         */
        public string ServerId { get; set; }

        /**
         *
         * Doysa yolunu barındırır.
         *
         
         *
         */
        public string FilePath { get; set; }

        /**
         *
         * Verileri dosyadan yükler.
         *
         
         *
         */
        public abstract void Load();

        /**
         *
         * İşlemleri başlatır.
         *
         
         *
         */
        public abstract void Start(string serverId);

        /**
         *
         * Verileri diske yazar.
         *
         
         *
         */
        public abstract void SaveToDisk();

        /**
         *
         * Verileri diske yazar.
         *
         
         *
         */
        public bool WriteToDisk<T>(T storage)
        {
            if (storage == null)
            {
                Log.Error(string.Format("Storage.WriteToDisk -> Error Code (0x01): {0}", this.FilePath));
                return false;
            }

            var data = NetworkTools.Serialize(storage);
            if (data == null)
            {
                Log.Error(string.Format("Storage.WriteToDisk -> Error Code (0x02): {0}", this.FilePath));
                return false;
            }

            if (!data.IsValid())
            {
                Log.Error(string.Format("Storage.WriteToDisk -> Error Code (0x03): {0}", this.FilePath));
                return false;
            }

            return data.WriteToDisk(this.FilePath);
        }

        /**
         *
         * Verileri diske yazar.
         *
         
         *
         */
        public bool InitializePath()
        {
            if (this.FilePath.IsNull())
            {
                return false;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(this.FilePath));
            return true;
        }
    }
}
