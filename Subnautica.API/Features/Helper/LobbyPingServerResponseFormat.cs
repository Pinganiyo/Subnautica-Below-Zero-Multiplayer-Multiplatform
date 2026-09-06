namespace Subnautica.API.Features.Helper
{
    public class LobbyPingServerResponseFormat
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
    }
}
