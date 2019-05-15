using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MaintenanceOrderFilter : ContentPage
	{
		public MaintenanceOrderFilter ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}