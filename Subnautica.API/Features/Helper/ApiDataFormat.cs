namespace Subnautica.API.Features.Helper
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    using Subnautica.API.Extensions;

    public class ApiDataFormat
    {
        /**
         *
         * IsStatus değerini barındırır.
         *
         
         *
         */
        public bool IsStatus { get; set; }
        
        /**
         *
         * IsPreRelease değerini barındırır.
         *
         
         *
         */
        public bool IsPreRelease { get; set; }

        /**
         *
         * Version değerini barındırır.
         *
         
         *
         */
        public string Version { get; set; }

        /**
         *
         * Assets değerini barındırır.
         *
         
         *
         */
        public List<ApiDataAssetsFormat> Assets { get; set; } = new List<ApiDataAssetsFormat>();

        /**
         *
         * Downloads değerini barındırır.
         *
         
         *
         */
        public List<ApiDataDownloadItem> Downloads { get; set; } = new List<ApiDataDownloadItem>();

        /**
         *
         * Languages değerini barındırır.
         *
         
         *
         */
        public List<string> Languages { get; set; } = new List<string>();

        /**
         *
         * Toplam dosya boyutunu döner.
         *
         
         *
         */
        public double GetTotalFileSize()
        {
            long totalFileSize = 0;

            foreach (var item in this.Downloads)
            {
                totalFileSize += item.FileSize;
            }

            return (double)totalFileSize;
        }

        /**
         *
         * İndirilecek dosyaları döner.
         *
         
         *
         */
        public List<ApiDataDownloadItem> GetDownloadFiles()
        {
            var files = new List<ApiDataDownloadItem>();

            foreach (var item in this.Downloads)
            {
                files.Add(this.GetDownloadItem(item.TempName, item.LocalPath, item.RemoteUrl, item.FileSize, item.CheckVersion, item.CustomVersion));
            }

            return files;
        }

        /**
         *
         * İndirme nesnesini döner.
         *
         
         *
         */
        private ApiDataDownloadItem GetDownloadItem(string tempname, string localPath, string remoteUrl, long fileSize, bool checkVersion, string customVersion)
        {
            return new ApiDataDownloadItem()
            {
                TempName      = tempname,
                LocalPath     = string.Format("{0}{1}{2}", localPath, localPath.IsNull() ? "" : Paths.DS.ToString(), tempname.IsNotNull() ? tempname : Path.GetFileName(remoteUrl)),
                RemoteUrl     = remoteUrl,
                FileSize      = fileSize,
                CheckVersion  = checkVersion,
                CustomVersion = customVersion,
            };
        }
    }

    public class ApiDataAssetsFormat
    {
        /**
         *
         * Path değerini barındırır.
         *
         
         *
         */
        public string Path { get; set; }

        /**
         *
         * Url değerini barındırır.
         *
         
         *
         */
        public string Url { get; set; }
    }

    public class ApiDataDownloadItem
    {
        /**
         *
         * TempName değerini barındırır.
         *
         
         *
         */
        public string TempName { get; set; }

        /**
         *
         * CheckVersion değerini barındırır.
         *
         
         *
         */
        public bool CheckVersion { get; set; }

        /**
         *
         * CurrentVersion değerini barındırır.
         *
         
         *
         */
        public string CurrentVersion { get; set; }

        /**
         *
         * CustomVersion değerini barındırır.
         *
         
         *
         */
        public string CustomVersion { get; set; }

        /**
         *
         * LocalPath değerini barındırır.
         *
         
         *
         */
        public string LocalPath { get; set; }

        /**
         *
         * RemoteUrl değerini barındırır.
         *
         
         *
         */
        public string RemoteUrl { get; set; }

        /**
         *
         * FileSize değerini barındırır.
         *
         
         *
         */
        public long FileSize { get; set; }
    }
}