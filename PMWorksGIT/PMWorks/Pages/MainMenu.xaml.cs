using System;
using System.Collections.Generic;
using PMWorks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMWorks.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : MasterDetailPage
    {
        public List<MainMenuItem> MainMenuItems = new List<MainMenuItem>();

        public MainMenu()
        {
            InitializeComponent();

            var page1 = new MainMenuItem() { Title = "Home", TargetType = typeof(SelectHotelPage) };
            var page2 = new MainMenuItem() { Title = "Profile", TargetType = typeof(ProfilePage) };
            var page3 = new MainMenuItem() { Title = "Discover Options", TargetType = typeof(DiscoverOptions) };
            var page4 = new MainMenuItem() { Title = "Notifications", TargetType = typeof(NotificationsPage) };

            MainMenuItems.Add(page1);
            MainMenuItems.Add(page2);
            MainMenuItems.Add(page3);
            MainMenuItems.Add(page4);


            navigationDrawerList.ItemsSource = MainMenuItems;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SelectHotelPage)));


        }

        // When a MenuItem is selected.
        public async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMenuItem;
            if (item != null)
            {
                if (item.Title.Equals("Home"))
                {
                    await Navigation.PushModalAsync(new SelectHotelPage());
                }
                else if (item.Title.Equals("Profile"))
                {
                    await Navigation.PushModalAsync(new ProfilePage());
                }
                else if (item.Title.Equals("Discover Options"))
                {
                   await Navigation.PushModalAsync(new DiscoverOptions());
                }
                else 
                {
                   await Navigation.PushModalAsync(new NotificationsPage());
                }

                navigationDrawerList.SelectedItem = null;
                IsPresented = false;
            }
        }

        private async void LogOut_Clicked(object sender, EventArgs e)
        {
            var authenticationService = DependencyService.Get<IAuthenticationService>();

            try
            {
                authenticationService.LogOut(AuthenticationParameters.Authority, AuthenticationParameters.ReturnUri);
                await Navigation.PopModalAsync(true);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Failure", ex.Message, "Ok");
            }

        }
    }
}
