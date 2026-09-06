namespace Subnautica.API.Features.Helper
{
    using System.Collections.Generic;
    
    public class ApiCreditsDataFormat
    {
        /**
         *
         * ProjectOwner değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat ProjectOwner { get; set; } = new ApiCreditsDataItemFormat();
        
        /**
         *
         * ServerOwners değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat ServerOwners { get; set; } = new ApiCreditsDataItemFormat();
        
        /**
         *
         * DiscordAdmins değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat DiscordAdmins { get; set; } = new ApiCreditsDataItemFormat();
        
        /**
         *
         * DiscordMods değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat DiscordMods { get; set; } = new ApiCreditsDataItemFormat();
        
        /**
         *
         * PatreonSupporters değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat PatreonSupporters { get; set; } = new ApiCreditsDataItemFormat();
        
        /**
         *
         * Translators değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat Translators { get; set; } = new ApiCreditsDataItemFormat();
        
        /**
         *
         * AlphaTesters değerini barındırır.
         *
         
         *
         */
        public ApiCreditsDataItemFormat AlphaTesters { get; set; } = new ApiCreditsDataItemFormat();
    }

    public class ApiCreditsDataItemFormat
    {
        /**
         *
         * Grup adını barındırır.
         *
         
         *
         */        
        public string Name { get; set; }

        /**
         *
         * Grup adını barındırır.
         *
         
         *
         */        
        public List<ApiCreditsDataMemberItemFormat> Members { get; set; } = new List<ApiCreditsDataMemberItemFormat>();
    }

    public class ApiCreditsDataMemberItemFormat
    {
        /**
         *
         * İsmi barındırır.
         *
         
         *
         */        
        public string Name { get; set; }
    }
}
