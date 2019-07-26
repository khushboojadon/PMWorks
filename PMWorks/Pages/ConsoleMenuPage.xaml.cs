using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class ConsoleMenuPage : ContentPage
    {
        public ConsoleMenuPage()
        {
            InitializeComponent();
        }



public async void Handle_Tapped(object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new ConsoleMaintenanceOrder());
        }

public async void Handles_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConsoleScheduleMaintenanceFilter());
        }
    }
}
