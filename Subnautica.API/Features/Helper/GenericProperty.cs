namespace Subnautica.API.Features.Helper
{
    public class GenericProperty
    {
        /**
         *
         * Anahtarı barındırır.
         *
         
         *
         */
        public string Key { get; set; }

        /**
         *
         * Değeri barındırır.
         *
         
         *
         */
        public object Value { get; set; }

        /**
         *
         * Sınıf ayarlamalarını yapar.
         *
         
         *
         */
        public GenericProperty(string key, object value)
        {
            this.Key   = key;
            this.Value = value;
        }

        /**
         *
         * Value değerini değiştirir.
         *
         
         *
         */
        public void SetValue(object value)
        {
            this.Value = value;
        }

        /**
         *
         * Key döner.
         *
         
         *
         */
        public string GetKey()
        {
            return this.Key;
        }

        /**
         *
         * Özellik döner.
         *
         
         *
         */
        public T GetValue<T>()
        {
            if (this.Value == null)
            {
                return default(T);
            }

            return (T) this.Value;
        }
    }
}
