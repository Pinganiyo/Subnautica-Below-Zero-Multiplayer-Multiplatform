namespace Subnautica.API.Features
{
    using System.Diagnostics;

    public class StopwatchItem : Stopwatch
    {
        /**
         *
         * Gecikme zamanı
         *
         
         *
         */
        public float DelayTime { get; set; }

        /**
         *
         * Veri barındırır.
         *
         
         *
         */
        public object CustomData { get; set; }

        /**
         *
         * Sınıf ayarlarını yapar.
         *
         
         *
         */
        public StopwatchItem(float delayTime = -1f, object customData = null, bool autoStart = true)
        {
            this.DelayTime  = delayTime;
            this.CustomData = customData;

            if (autoStart)
            {
                this.Start();
            }
        }

        /**
         *
         * Belirtilen süre doldu mu?
         *
         
         *
         */
        public bool IsFinished()
        {
            return this.ElapsedMilliseconds >= this.DelayTime;
        }

        /**
         *
         * Geçen zamanı döner.
         *
         
         *
         */
        public float ElapsedTime()
        {
            return this.ElapsedMilliseconds;
        }

        /**
         *
         * Belirtilen süre doldu mu?
         *
         
         *
         */
        public T GetCustomData<T>()
        {
            if (this.CustomData == null)
            {
                return default;
            }
            
            return (T) this.CustomData;
        }
    }
}
