using PMWorks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsoleScheduleMaintenance : ContentPage
    {
        public ConsoleScheduleMaintenance()
        {
            InitializeComponent();
            MaintenanceList.ItemsSource = new ConsoleScheduleList().ListOfConsoleMaintenanceSchedule();
        }
        private void ButtonFilterClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConsoleScheduleMaintenanceFilter());
        }
    }
}