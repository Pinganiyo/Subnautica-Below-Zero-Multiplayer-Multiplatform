namespace Subnautica.Client.Abstracts
{
    public class BaseProcessor
    {
        /**
         *
         * Sınıf başlatılırken tetiklenir.
         *
         
         *
         */
        public virtual void OnStart()
        {

        }

        /**
         *
         * Her karede tetiklenir.
         *
         
         *
         */
        public virtual void OnUpdate()
        {

        }

        /**
         *
         * Her kare sonunda tetiklenir.
         *
         
         *
         */
        public virtual void OnLateUpdate()
        {

        }

        /**
         *
         * Her Sabit karede tetiklenir.
         *
         
         *
         */
        public virtual void OnFixedUpdate()
        {

        }

        /**
         *
         * Ana menüye dönünce tetiklenir.
         *
         
         *
         */
        public virtual void OnDispose()
        {

        }

        /**
         *
         * İşlem tamamlanma durumunu değiştirir
         *
         
         *
         */
        public void OnFinishedSuccessCallback()
        {
            this.SetFinished(true);
        }

        /**
         *
         * İşlem tamamlanma durumunu değiştirir
         *
         
         *
         */
        public void SetFinished(bool isFinished)
        {
            this.isFinished = isFinished;
        }

        /**
         *
         * İşlem tamamlandı mı?
         *
         
         *
         */
        public bool IsFinished()
        {
            return this.isFinished;
        }

        /**
         *
         * Sonraki kare beklenme durumunu değiştirir.
         *
         
         *
         */
        public void SetWaitingForNextFrame(bool isWaitingForNextFrame)
        {
            this.isWaitingForNextFrame = isWaitingForNextFrame;
        }

        /**
         *
         * Sonraki kare bekleniyor mu?
         *
         
         *
         */
        public bool IsWaitingForNextFrame()
        {
            return this.isWaitingForNextFrame;
        }

        /**
         *
         * İşlem tamamlanma durumunu barındırır
         *
         
         *
         */
        private bool isFinished { get; set; } = false;

        /**
         *
         * Sonraki kare beklensin mi? (Sadece asenkron işlemler için)
         *
         
         *
         */
        private bool isWaitingForNextFrame { get; set; } = false;
    }
}
