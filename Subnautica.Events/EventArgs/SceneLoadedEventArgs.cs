namespace Subnautica.Events.EventArgs
{
    using UnityEngine.SceneManagement;
    using System;

    public class SceneLoadedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         
         *
         */
        public SceneLoadedEventArgs(Scene scene)
        {
            Scene = scene;
        }

        /**
         *
         * Olayın çalıştırılıp/çalıştırılmayacağı
         *
         
         *
         */
        public Scene Scene { get; set; }
    }
}
