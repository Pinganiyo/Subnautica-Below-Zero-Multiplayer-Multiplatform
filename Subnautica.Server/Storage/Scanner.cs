namespace Subnautica.Server.Storage
{
    using System;
    using System.IO;

    using Subnautica.API.Features;
    using Subnautica.Network.Core;
    using Subnautica.Server.Abstracts;

    using ScannerStorage = Network.Models.Storage.Scanner;

    public class Scanner : BaseStorage
    {
        /**
         *
         * Encyclopedia sınıfını barındırır.
         *
         
         *
         */
        public ScannerStorage.Scanner Storage { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public override void Start(string serverId)
        {
            this.ServerId = serverId;
            this.FilePath = Paths.GetMultiplayerServerSavePath(this.ServerId, "Scanner.bin");
            this.InitializePath();
            this.Load();
        }
        /**
         *
         * Sunucu ansiklopedi verilerini belleğe yükler.
         *
         
         *
         */
        public override void Load()
        {
            if (File.Exists(this.FilePath))
            {
                lock (this.ProcessLock)
                {
                    try
                    {
                        this.Storage = NetworkTools.Deserialize<ScannerStorage.Scanner>(File.ReadAllBytes(this.FilePath));
                    }
                    catch (Exception e)
                    {
                        Log.Error($"Scanner.Load: {e}");
                    }
                }
            }

            if (this.Storage == null)
            {
                this.Storage = new ScannerStorage.Scanner();
                this.SaveToDisk();
            }

            if (Core.Server.DEBUG)
            {
                Log.Info("Scanned Technologies: ");
                Log.Info("---------------------------------------------------------------");
                foreach (var item in this.Storage.Technologies)
                {
                    Log.Info(item);
                }
                Log.Info("---------------------------------------------------------------");
            }
        }

        /**
         *
         * Verileri diske yazar
         *
         
         *
         */
        public override void SaveToDisk()
        {
            lock (this.ProcessLock)
            {
                this.WriteToDisk(this.Storage);
            }
        }

        /**
         *
         * Açılmış teknolojiyi ekler.
         *
         
         *
         */
        public bool AddScannedTechnology(TechType techType)
        {
            lock (this.ProcessLock)
            {
                if (!this.Storage.Technologies.Contains(techType))
                {
                    this.Storage.Technologies.Add(techType);
                    return true;
                }

                return false;
            }
        }
    }
}
