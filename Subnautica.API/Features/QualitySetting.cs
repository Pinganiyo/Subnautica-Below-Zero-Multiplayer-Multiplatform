namespace Subnautica.API.Features
{
    using UnityEngine;

    public class QualitySetting
    {
        /**
         *
         * Eski FPS Değeri
         *
         
         *
         */
        private static int OldFrameRate  = 0;

        /**
         *
         * Eski VSYNC Durumu
         *
         
         *
         */
        private static bool OldVsync = false;

        /**
         *
         * FPS Miktarını değiştirir.
         *
         
         *
         */
        public static void EnableFastMode()
        {
            if (OldFrameRate != 501)
            {
                OldFrameRate = GraphicsUtil.GetFrameRate();
                OldVsync     = GraphicsUtil.GetVSyncEnabled();
            }

            Application.targetFrameRate = 501;
            UnityEngine.QualitySettings.vSyncCount = 0;
        }

        /**
         *
         * FPS Miktarını değiştirir.
         *
         
         *
         */
        public static void DisableFastMode()
        {
            Reset();
        }

        /**
         *
         * Ayarları varsayılan yapar.
         *
         
         *
         */
        public static void Reset()
        {
            if (OldFrameRate != 0)
            {
                Application.targetFrameRate = Mathf.Min(OldFrameRate, 500);
                UnityEngine.QualitySettings.vSyncCount = OldVsync ? 1 : 0;

                OldFrameRate = 0;
                OldVsync     = false;
            }
        }
    }
}
