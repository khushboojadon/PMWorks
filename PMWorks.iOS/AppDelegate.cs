
using Foundation;
using UIKit;

namespace PMWorks.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public static UIWindow keywindow;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init();

            keywindow = new UIWindow(UIScreen.MainScreen.Bounds);

            //UINavigationBar.Appearance.BarTintColor = UIColor.FromRGBA(50, 71, 85, 1);
            //UINavigationBar.Appearance.TintColor = UIColor.White;
            //UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;



            LoadApplication(new App());

            return base.FinishedLaunching(app, options);


        }
    }
}
