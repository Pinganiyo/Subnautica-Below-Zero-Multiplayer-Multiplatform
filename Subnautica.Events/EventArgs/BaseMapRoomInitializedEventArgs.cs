namespace Subnautica.Events.EventArgs
{
    using System;

    public class BaseMapRoomInitializedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseMapRoomInitializedEventArgs(uGUI_MapRoomScanner mapRoom)
        {
            this.MapRoom = mapRoom;
        }

        /**
         *
         * MapRoom Değerini barındırır.
         *
         
         *
         */
        public uGUI_MapRoomScanner MapRoom { get; set; }
    }
}
