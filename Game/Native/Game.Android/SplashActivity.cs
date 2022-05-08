using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;

namespace Game.Droid
{
    [Activity(Theme = "@style/CustomTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();

            StartApplication();
        }

        private void StartApplication()
        {
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}