using PMWorks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HotelDetails : ContentPage
	{
		public HotelDetails (string name)
		{
			InitializeComponent ();
            hotelName.Text = name;
            MaintenanceList.ItemsSource = new MaintenanceOrderList().ListOfMaintenanceOrder();
		}
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var Orders = e.Item as MaintenanceOrderList;
            await Navigation.PushAsync(new MaintenanceOrderFilter());

        }

    public async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FilterScreen());
        }
    }
}