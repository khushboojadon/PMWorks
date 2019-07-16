using System.Collections.ObjectModel;using PMWorks.Models;using Xamarin.Forms;using System.Linq;using System.Threading.Tasks;

namespace PMWorks.Pages{    public partial class SelectHotelPage : ContentPage    {        public static ObservableCollection<Grouping<string, HotelsList>> HotelsGrouped { get; set; }        public static ObservableCollection<HotelsList> Hotels { get; set; }        public SelectHotelPage()        {            InitializeComponent();            Hotels = new HotelsList().ListOfHotels();


            BindingContext = Hotels;            collview.SelectionChanged += Collview_SelectionChanged;        }


        private async void Collview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = (e.CurrentSelection.FirstOrDefault() as HotelsList)?.HotelName;

            await Navigation.PushAsync(new MenuPage(name));

            //await Navigation.PushAsync(new NotificationsPage());
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)        {
            //thats all you need to make a search  

            if (string.IsNullOrEmpty(e.NewTextValue))            {                BindingContext = Hotels;            }            else            {                BindingContext = Hotels.Where(x => x.HotelName.StartsWith(e.NewTextValue, System.StringComparison.OrdinalIgnoreCase));            }        }    }}