using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Subnautica.API.Extensions;

namespace Subnautica.API.Features.Netbird
{
    public class NetbirdContainerItem
    {
        /**
         *
         * Bağlantı durumunu barındırır.
         *
         
         *
         */
        public bool IsConnected { get; private set; }

        /**
         *
         * Hata Mesajını barındırır.
         *
         
         *
         */
        public string ErrorMessage { get; private set; }

        /**
         *
         * Bağlantı durumunu değiştirir.
         *
         
         *
         */
        public void SetConnected(bool isConnected)
        {
            this.IsConnected = isConnected;
        }

        /**
         *
         * Hata Mesajını değiştirir.
         *
         
         *
         */
        public void SetErrorMessage(string errorMessage)
        {
            if (errorMessage.IsNotNull())
            {
                this.ErrorMessage = errorMessage;
            }
        }

        /**
         *
         * Hata var mı?
         *
         
         *
         */
        public bool IsAnyError()
        {
            return this.ErrorMessage.IsNotNull();
        }
    }
}
