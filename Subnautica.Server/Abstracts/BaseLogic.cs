namespace Subnautica.Server.Abstracts
{
    public abstract class BaseLogic
    {
        /**
         *
         * Sınıfı başlatır
         *
         
         *
         */
        public virtual void OnStart()
        {

        }

        /**
         *
         * Belirli aralıklarla tetiklenir.
         *
         
         *
         */
        public virtual void OnUpdate(float deltaTime)
        {

        }

        /**
         *
         * Belirli aralıklarla tetiklenir.
         *
         
         *
         */
        public virtual void OnAsyncUpdate()
        {

        }

        /**
         *
         * Belirli aralıklarla tetiklenir.
         *
         
         *
         */
        public virtual void OnFixedUpdate(float fixedDeltaTime)
        {

        }

        /**
         *
         * Belirli aralıklarla tetiklenir.
         *
         
         *
         */
        public virtual void OnUnscaledFixedUpdate(float fixedDeltaTime)
        {

        }
    }
}
