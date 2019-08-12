using System;

using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            CheckTokens();
        }

        private async void CheckTokens()
        {
            var authenticationService = DependencyService.Get<IAuthenticationService>();

            try
            {
                //authenticate with existing token if any
                var authenticationResult = await authenticationService.Authenticate(
                    AuthenticationParameters.Authority,
                    AuthenticationParameters.GraphResourceUri,
                    AuthenticationParameters.ApplicationId,
                    AuthenticationParameters.ReturnUri);

                var userInfo = authenticationResult.UserInfo;

                if (userInfo != null)
                {
                    var userName = $"{userInfo.DisplayableId}";
                    await DisplayAlert("Success", userName, "Ok");
                    await Navigation.PushAsync(new MainTabPage());
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
                // not logged in or token expired take to login screen
                await Navigation.PushAsync(new Login());
            }
        }
    }
}
