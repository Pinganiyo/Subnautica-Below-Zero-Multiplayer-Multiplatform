namespace Subnautica.API.Features.Helper
{
    public class LobbyCreateServerResponse
    {
        /**
         *
         * Hata durumu
         *
         
         *
         */
        public bool IsError { get; set; }

        /**
         *
         * Hata kodu
         *
         
         *
         */
        public string ErrorMessage { get; set; }

        /**
         *
         * Davet kodu
         *
         
         *
         */
        public string JoinCode { get; set; }

        /**
         *
         * AccessToken Değeri
         *
         
         *
         */
        public string AccessToken { get; set; }

        /**
         *
         * IpAddress
         *
         
         *
         */
        public string ServerIp { get; set; }

        /**
         *
         * Port değeri
         *
         
         *
         */
        public int ServerPort { get; set; }
    }
}
