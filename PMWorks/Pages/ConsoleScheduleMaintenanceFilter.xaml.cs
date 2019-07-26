using PMWorks.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ConsoleScheduleMaintenanceFilter : ContentPage
{
public static ObservableCollection<Grouping<string, CatogriesList>> HotelsGrouped { get; set; }

public static ObservableCollection<CatogriesList> Catogries { get; set; }

public ConsoleScheduleMaintenanceFilter()
{
InitializeComponent();
Catogries = new CatogriesList().ListOfCategory();
BindingContext = Catogries;
}
        private async void Close_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void BtnFilterClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
}
}