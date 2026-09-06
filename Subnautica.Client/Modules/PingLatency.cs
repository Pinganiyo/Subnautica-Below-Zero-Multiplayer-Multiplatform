namespace Subnautica.Client.Modules
{
    using TMPro;

    using UnityEngine;

    public class PingLatency
    {
        /**
         *
         * pingLatencyGameObject nesnesini barındırır.
         *
         
         *
         */
        private static GameObject pingLatencyGameObject;

        /**
         *
         * pingLatencyText nesnesini barındırır.
         *
         
         *
         */
        private static TextMeshProUGUI pingLatencyComponent;

        /**
         *
         * Oyun tamamen başlatıldığında tetiklenir.
         *
         
         *
         */
        public static void OnWorldLoaded()
        {
            CreatePingLatencyGameObject();
        }

        /**
         *
         * Ping nesnesini oluşturur.
         *
         
         *
         */
        public static void CreatePingLatencyGameObject()
        {
            if (pingLatencyGameObject != null)
            {
                GameObject.Destroy(pingLatencyGameObject);
            }

            pingLatencyGameObject = GameObject.Instantiate<GameObject>(ErrorMessage.main.prefabMessage);
            pingLatencyGameObject.SetActive(true);

            pingLatencyComponent = pingLatencyGameObject.GetComponent<TextMeshProUGUI>();
            pingLatencyComponent.rectTransform.SetParent(ErrorMessage.main.messageCanvas, false);

            Vector3 position = pingLatencyComponent.rectTransform.localPosition;

            pingLatencyComponent.rectTransform.localPosition = new Vector2(-95f + position.x, 95f + position.y);
            pingLatencyComponent.fontSize = 14f;
            pingLatencyComponent.text = "";
        }

        /**
         *
         * Gözüken pingi değiştirir.
         *
         
         *
         */
        public static void SetPingText(long ping)
        {
            if (pingLatencyComponent != null)
            {
                if (ping <= 150)
                {
                    pingLatencyComponent.text = string.Format("{0} ms", ping);
                }
                else if (ping <= 250)
                {
                    pingLatencyComponent.text = string.Format("<color=orange>{0} ms</color>", ping);
                }
                else
                {
                    pingLatencyComponent.text = string.Format("<color=red>{0} ms</color>", ping);
                }
            }
        }
    }
}
