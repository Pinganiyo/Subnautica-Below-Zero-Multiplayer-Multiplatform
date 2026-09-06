namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BaseControlRoomMinimapExitingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseControlRoomMinimapExitingEventArgs(string uniqueId, Vector3 mapPosition)
        {
            this.UniqueId    = uniqueId;
            this.MapPosition = mapPosition;
        }

        /**
         *
         * UniqueId değeri
         *
         
         *
         */
        public string UniqueId { get; set; }

        /**
         *
         * MapPosition değeri
         *
         
         *
         */
        public Vector3 MapPosition { get; set; }
    }
}
