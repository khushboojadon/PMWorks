using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Content;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Android.Views;

namespace PMWorks.Droid
{
    [Activity(Label = "PMWorks", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init(this, bundle);
            
            //if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            //{
            //    Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            //    Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            //    Window.SetStatusBarColor(Android.Graphics.Color.Black);
            //}
            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            AuthenticationAgentContinuationHelper.SetAuthenticationAgentContinuationEventArgs(requestCode, resultCode, data);
        }
    }
}