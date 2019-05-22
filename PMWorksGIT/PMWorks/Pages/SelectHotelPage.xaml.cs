using PMWorks.Models;
using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class SelectHotelPage : ContentPage
    {
        public SelectHotelPage()

        {
            InitializeComponent();
            hotelList.ItemsSource = new HotelsList().ListOfHotels();
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as HotelsList;
            await Navigation.PushAsync(new MenuPage(details.HotelName));
        }
    }
}
