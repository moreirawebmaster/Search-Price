using Android.App;
using Android.Content;
using Android.Content.PM;

namespace SearchPrice.App.Droid
{
    [Activity(Label = "Search Price",
        Icon = "@drawable/logo", 
        MainLauncher = true, 
        NoHistory = true, 
        Theme = "@style/Theme.Splash",
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            base.OnCreate(bundle);
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}