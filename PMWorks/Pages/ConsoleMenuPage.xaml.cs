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
public async void Tapped_Order(object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new ConsoleOrderMaintenance());
        }

public async void Tapped_Schedule(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ConsoleScheduleMaintenance());
        }
    }
}
