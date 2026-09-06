namespace Subnautica.Client.Extensions
{
    using System;

    using Subnautica.API.Features;

    public static class ProtobufExtensions
    {
        /**
         *
         * Hücre türünü barındırır.
         *
         
         *
         */
        private static Type CellMode = typeof(ProtobufClass_CellMode);

        /**
         *
         * İnşaat türünü barındırır.
         *
         
         *
         */
        private static Type ConstructionMode = typeof(ProtobufClass_ConstructionMode);

        /**
         *
         * Id değerini boş yapar.
         *
         
         *
         */
        private static Type EmptyIdMode = typeof(ProtobufClass_EmptyId);

        /**
         *
         * Hücre modunu aktif eder.
         *
         
         *
         */
        public static void SetCellModeActive(this global::ProtobufSerializer serializer, bool isActive)
        {
            if (isActive)
            {
                if (!serializer.IsCellModeActive())
                {
                    serializer.canSerializeCache.Add(CellMode, true);
                }
            }
            else
            {
                serializer.RemoveCellMode();
            }
        }

        /**
         *
         * Hücre modunu pasif eder.
         *
         
         *
         */
        public static void RemoveCellMode(this global::ProtobufSerializer serializer)
        {
            serializer.canSerializeCache.Remove(CellMode);
        }

        /**
         *
         * Hücre modunu kontrol eder.
         *
         
         *
         */
        public static bool IsCellModeActive(this global::ProtobufSerializer serializer)
        {
            return serializer.canSerializeCache.ContainsKey(CellMode);
        }

        /**
         *
         * İnşaat modunu aktif eder.
         *
         
         *
         */
        public static void SetConstructionModeActive(this global::ProtobufSerializer serializer, bool isActive)
        {
            if (isActive)
            {
                if (!serializer.IsConstructionModeActive())
                {
                    serializer.canSerializeCache.Add(ConstructionMode, true);
                }
            }
            else
            {
                serializer.RemoveConstructionMode();
            }
        }

        /**
         *
         * İnşaat modunu pasif eder.
         *
         
         *
         */
        public static void RemoveConstructionMode(this global::ProtobufSerializer serializer)
        {
            serializer.canSerializeCache.Remove(ConstructionMode);
        }

        /**
         *
         * İnşaat modunu kontrol eder.
         *
         
         *
         */
        public static bool IsConstructionModeActive(this global::ProtobufSerializer serializer)
        {
            return serializer.canSerializeCache.ContainsKey(ConstructionMode);
        }

        /**
         *
         * İnşaat modunu aktif eder.
         *
         
         *
         */
        public static void SetIdIgnoreModeActive(this global::ProtobufSerializer serializer, bool isActive)
        {
            if (isActive)
            {
                if (!serializer.IsIdIgnoreModeActive())
                {
                    serializer.canSerializeCache.Add(EmptyIdMode, true);
                }
            }
            else
            {
                serializer.RemoveIdIgnoreModeActive();
            }
        }

        /**
         *
         * İnşaat modunu pasif eder.
         *
         
         *
         */
        public static void RemoveIdIgnoreModeActive(this global::ProtobufSerializer serializer)
        {
            serializer.canSerializeCache.Remove(EmptyIdMode);
        }

        /**
         *
         * İnşaat modunu kontrol eder.
         *
         
         *
         */
        public static bool IsIdIgnoreModeActive(this global::ProtobufSerializer serializer)
        {
            return serializer.canSerializeCache.ContainsKey(EmptyIdMode);
        }
    }

    public class ProtobufClass_CellMode
    {

    }

    public class ProtobufClass_ConstructionMode
    {

    }

    public class ProtobufClass_EmptyId
    {

    }
}
