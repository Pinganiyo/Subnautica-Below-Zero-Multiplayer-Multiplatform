namespace Subnautica.API.Features
{
    public class IntroVignette
    {
        public static bool isIntroActive = false;
        public static IntroVignette main = new IntroVignette();
        public global::Player player => global::Player.main;
        public void OnDone()
        {
            isIntroActive = false;
        }
    }
}
