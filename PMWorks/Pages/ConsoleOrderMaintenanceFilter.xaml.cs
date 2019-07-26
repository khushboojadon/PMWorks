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
    public partial class ConsoleMaintenanceOrder : ContentPage
    {
        public static ObservableCollection<Grouping<string, CatogriesList>> HotelsGrouped { get; set; }

        public static ObservableCollection<CatogriesList> Catogries { get; set; }

        public ConsoleMaintenanceOrder()
        {
            InitializeComponent();
            Catogries = new CatogriesList().ListOfCategory();
            BindingContext = Catogries;
        }
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            //textlbl.Text = isToggled.ToString();
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