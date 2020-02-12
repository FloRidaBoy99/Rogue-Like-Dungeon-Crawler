using Assets.HeroEditor4D.Common.CharacterScripts;

namespace Assets.HeroEditor4D.Common.ExampleScripts
{
    public static class CharacterSetup
    {
        public static void Setup(Character dummy, CharacterAppearance appearance)
        {
            appearance.Setup(dummy);
        }
    }
}