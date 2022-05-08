using Xamarin.Essentials;

namespace Game.Common.Settings
{
    public static class Settings
    {
        public static bool EnableTests
        {
            get => Preferences.Get(nameof(EnableTests), false);
            set => Preferences.Set(nameof(EnableTests), value);
        }

        public static void ResetAll()
        {
            Preferences.Clear();
        }
    }
}
