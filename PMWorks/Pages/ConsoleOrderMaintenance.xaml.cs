using System;
using System.Collections.Generic;
using PMWorks.Models;
using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class ConsoleOrderMaintenance : ContentPage
    {
        public ConsoleOrderMaintenance()
        {
            InitializeComponent();

            //selectedHotelLbl.Text = name;
            MaintenanceList.ItemsSource = new MaintenanceOrderList().ListOfMaintenanceOrder();
        }

        private void ButtonFilterClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConsoleMaintenanceOrder());
        }

    }
}