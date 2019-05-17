using System;
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
    }
}