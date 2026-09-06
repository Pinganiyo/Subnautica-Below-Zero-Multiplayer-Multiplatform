namespace Subnautica.API.Features
{
    using System.Collections.Generic;
    using System.IO;

    using Subnautica.Client.Extensions;

    using UnityEngine;

    using UWE;

    public class Serializer
    {
        /**
         *
         * Benzersiz idleri önbellekte barındırır.
         *
         
         *
         */
        private static Dictionary<string, string> UniqueIds = new Dictionary<string, string>();

        /**
         *
         * Ebeveynleri barındırır.
         *
         
         *
         */
        private static Dictionary<int, Transform> ParentGameObjects = new Dictionary<int, Transform>();

        /**
         *
         * Benzersiz idleri önbellekte barındırır.
         *
         
         *
         */
        private static float LastInteractTime = 0f;

        /**
         *
         * Benzersiz idleri önbellekte barındırır.
         *
         
         *
         */
        private static int ProcessId = 1;

        /**
         *
         * Pickupable nesnesini serileştirir.
         *
         
         *
         */
        public static byte[] SerializeGameObject(Pickupable pickupable)
        {
            if (pickupable)
            {
                return Serializer.SerializeGameObject(pickupable.gameObject);
            }

            return null;
        }

        /**
         *
         * GameObject nesnesini serileştirir.
         *
         
         *
         */
        public static byte[] SerializeGameObject(GameObject gameObject)
        {
            if (gameObject)
            {
                using (PooledObject<ProtobufSerializer> proxy = ProtobufSerializerPool.GetProxy())
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        var processId = Serializer.HandleParent(gameObject, true);

                        Serializer.UniqueIdsToCache(gameObject);

                        proxy.Value.SetIdIgnoreModeActive(true);
                        proxy.Value.SerializeObjectTree(memoryStream, gameObject);
                        proxy.Value.SetIdIgnoreModeActive(false);

                        if (processId > 0)
                        {
                            Serializer.HandleParent(gameObject, false, processId);
                        }

                        return memoryStream.ToArray();
                    }
                }
            }

            return null;
        }

        /**
         *
         * Serileştirilmiş nesneyi oyun nesnesine dönüştürür.
         *
         
         *
         */
        public static CoroutineTask<GameObject> DeserializeGameObject(byte[] datas)
        {
            using (PooledObject<ProtobufSerializer> proxy = ProtobufSerializerPool.GetProxy())
            {
                using (MemoryStream stream = new MemoryStream(datas))
                {
                    return proxy.Value.DeserializeObjectTreeAsync(stream, false, false, 0);
                }
            }
        }

        /**
         *
         * UniqueId karşılığı döner.
         *
         
         *
         */
        public static string GetUniqueId(string uniqueId)
        {
            return UniqueIds[uniqueId];
        }

        /**
         *
         * Nesne ebeveynliğini kaldırıp ekler.
         *
         
         *
         */
        private static int HandleParent(GameObject gameObject, bool isParent, int oldProcessId = 0)
        {
            if (isParent)
            {
                if (gameObject.transform.parent == null)
                {
                    return 0;
                }

                var processId = Serializer.GetNewProcessId();

                ParentGameObjects[processId] = gameObject.transform.parent;

                gameObject.transform.parent = null;
                return processId;
            }
            else
            {
                if (oldProcessId > 0 && ParentGameObjects.ContainsKey(oldProcessId))
                {
                    gameObject.transform.parent = ParentGameObjects[oldProcessId];

                    ParentGameObjects.Remove(oldProcessId);
                }
            }

            return 0;
        }

        /**
         *
         * Yeni işlem idsini döner.
         *
         
         *
         */
        private static int GetNewProcessId()
        {
            if (ProcessId >= int.MaxValue)
            {
                ProcessId = 1;
            }

            return ProcessId++;
        }

        /**
         *
         * Önbelleğe idleri ekler.
         *
         
         *
         */
        private static void UniqueIdsToCache(GameObject gameObject)
        {
            if (DayNightCycle.main.timePassedAsFloat - Serializer.LastInteractTime > 5f)
            {
                Serializer.UniqueIds.Clear();
            }

            Serializer.LastInteractTime = DayNightCycle.main.timePassedAsFloat;

            var uidsProxy = ProtobufSerializer.uniqueIdentifiersPool.GetListProxy<UniqueIdentifier>();
            var uids      = uidsProxy.Value;

            gameObject.GetComponentsInChildren<UniqueIdentifier>(true, uids);

            for (int i = 0; i < uids.Count; i++)
            {
                var uid = uids[i];
                if (uid == false)
                {
                    uid = global::ProtobufSerializer.CreateTemporaryGameObject("DESTROYED OBJECT");
                }

                if (string.IsNullOrEmpty(uid.Id))
                {
                    uid.Id = Network.Identifier.GenerateUniqueId();
                }

                UniqueIds[uid.Id] = Network.Identifier.GenerateUniqueId();
            }

            uidsProxy.Dispose();
        }
    }
}
