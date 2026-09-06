namespace Subnautica.Server.Core
{
    public class Storages
    {        
        /**
         *
         * Encyclopedia sınıfını barındırır.
         *
         
         *
         */
        public Storage.Encyclopedia Encyclopedia { get; set; } = new Storage.Encyclopedia();

        /**
         *
         * Construction sınıfını barındırır.
         *
         
         *
         */
        public Storage.Construction Construction { get; set; } = new Storage.Construction();

        /**
         *
         * Technology sınıfını barındırır.
         *
         
         *
         */
        public Storage.Technology Technology { get; set; } = new Storage.Technology();

        /**
         *
         * Player sınıfını barındırır.
         *
         
         *
         */
        public Storage.Player Player { get; set; } = new Storage.Player();

        /**
         *
         * World sınıfını barındırır.
         *
         
         *
         */
        public Storage.World World { get; set; } = new Storage.World();

        /**
         *
         * Scanner sınıfını barındırır.
         *
         
         *
         */
        public Storage.Scanner Scanner { get; set; } = new Storage.Scanner();

        /**
         *
         * PictureFrame sınıfını barındırır.
         *
         
         *
         */
        public Storage.PictureFrame PictureFrame { get; set; } = new Storage.PictureFrame();

        /**
         *
         * Story sınıfını barındırır.
         *
         
         *
         */
        public Storage.Story Story { get; set; } = new Storage.Story();

        /**
         *
         * Depolamaları başlatır.
         *
         
         *
         */
        public void Start(string serverId)
        {
            this.Encyclopedia.Start(serverId);
            this.Construction.Start(serverId);
            this.PictureFrame.Start(serverId);
            this.Technology.Start(serverId);
            this.Scanner.Start(serverId);
            this.Player.Start(serverId);
            this.World.Start(serverId);
            this.Story.Start(serverId);
        }

        /**
         *
         * Sınıfı temizler.
         *
         
         *
         */
        public void Dispose()
        {
            this.Encyclopedia = null;
            this.Construction = null;
            this.PictureFrame = null;
            this.Technology   = null;
            this.Scanner      = null;
            this.Player       = null;
            this.World        = null;
            this.Story        = null;
        }
    }
}
