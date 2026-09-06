namespace Subnautica.API.Features.Helper
{
    public class FirewallItemFormat
    {
        /**
         *
         * Name değerini barındırır.
         *
         
         *
         */
        public string Name { get; set; }
        /**
         *
         * Description değerini barındırır.
         *
         
         *
         */
        public string Description { get; set; }

        /**
         *
         * Path değerini barındırır.
         *
         
         *
         */
        public string Path { get; set; }

        /**
         *
         * IsEnabled değerini barındırır.
         *
         
         *
         */
        public bool IsEnabled { get; set; }

         /**
         *
         * IsPublicProfile değerini barındırır.
         *
         
         *
         */       
        public bool IsPublicProfile { get; set; }

         /**
         *
         * IsPrivateProfile değerini barındırır.
         *
         
         *
         */       
        public bool IsPrivateProfile { get; set; }

        /**
         *
         * IsDomainProfile değerini barındırır.
         *
         
         *
         */        
        public bool IsDomainProfile { get; set; }

        /**
         *
         * IsUdp değerini barındırır.
         *
         
         *
         */
        public bool IsUdp { get; set; }

        /**
         *
         * IsTcp değerini barındırır.
         *
         
         *
         */
        public bool IsTcp { get; set; }

        /**
         *
         * IsAllow değerini barındırır.
         *
         
         *
         */
        public bool IsAllow { get; set; }
    }
}
