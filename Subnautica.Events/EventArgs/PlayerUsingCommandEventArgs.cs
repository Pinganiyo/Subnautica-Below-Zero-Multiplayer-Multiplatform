namespace Subnautica.Events.EventArgs
{
    using System;

    public class PlayerUsingCommandEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public PlayerUsingCommandEventArgs(string command, string fullCommand, bool isAllowed = true)
        {
            this.Command     = command.Trim();
            this.FullCommand = fullCommand.Trim();
            this.IsAllowed   = isAllowed;
        }

        /**
         *
         * Command Değerini barındırır.
         *
         
         *
         */
        public string Command { get; set; }

        /**
         *
         * FullCommand Değerini barındırır.
         *
         
         *
         */
        public string FullCommand { get; set; }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public bool IsAllowed { get; set; }
    }
}
