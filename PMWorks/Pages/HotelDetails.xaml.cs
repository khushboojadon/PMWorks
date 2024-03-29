﻿using PMWorks.Models;
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

            selectedHotelLbl.Text = name;
            MaintenanceList.ItemsSource = new MaintenanceOrderList().ListOfMaintenanceOrder();
		}
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var Orders = e.Item as MaintenanceOrderList;
            await Navigation.PushAsync(new MaintenanceOrderFilter());
        }

        private void ButtonFilterClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilterScreen());
        }


    }
}