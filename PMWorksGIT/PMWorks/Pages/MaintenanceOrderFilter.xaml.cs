using PMWorks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static PMWorks.Models.BrokenList;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MaintenanceOrderFilter : ContentPage
	{
		public MaintenanceOrderFilter ()
		{
			InitializeComponent ();
            MyList.ItemsSource = new Brokenlist().ListOfItems();
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            //textlbl.Text = isToggled.ToString();
        }
    }
}