using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class ProgressScreen : ContentPage
    {
        public ProgressScreen(string name)
        {
            InitializeComponent();
            hotelname.Text = name;
        }

        public async void RedOrdersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelDetails(hotelname.Text));
        }


        public async void YellowOrdersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelDetails(hotelname.Text));
        }


        public async void GreenOrdersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelDetails(hotelname.Text));
        }


        public async void AllOrdersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelDetails(hotelname.Text));
        }

    }
}
