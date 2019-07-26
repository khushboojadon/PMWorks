using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
	{
		public MenuPage (string name)
		{
			InitializeComponent ();
            hotelName.Text = name;            
		}


        public async void Reports_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelDetails(hotelName.Text));
        }

        public async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConsoleMenuPage());
        }

        public async void Progress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgressScreen(hotelName.Text));
        }
    }
}