namespace Subnautica.API.Features.Helper
{
    public class LobbyJoinServerResponseFormat
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
         * ServerIp
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
