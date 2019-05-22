using System;
using System.Collections.Generic;

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
                    var userName = $"{userInfo.GivenName} {userInfo.FamilyName}";
                    await DisplayAlert("Success", userName, "Ok");
                    await Navigation.PushModalAsync(new MainMenu());


                }
                else
                {
                    // not logged in or token expired take to login screen
                    await Navigation.PushModalAsync(new Login());
                }


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
