namespace Subnautica.Events.EventArgs
{
    using System;

    using UnityEngine;

    public class BaseControlRoomMinimapMovingEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public BaseControlRoomMinimapMovingEventArgs(string uniqueId, Vector3 position)
        {
            this.UniqueId = uniqueId;
            this.Position = position;
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
         * Position değeri
         *
         
         *
         */
        public Vector3 Position { get; set; }
    }
}
