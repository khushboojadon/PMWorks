using System;
using PMWorks.Pages;
using Xamarin.Forms;

namespace PMWorks
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

        }

        private async void LogIn_Clicked(object sender,EventArgs eventArgs)
        {
           var authenticationService = DependencyService.Get<IAuthenticationService>();

            try
            {
                var authenticationResult = await authenticationService.Authenticate(
                    AuthenticationParameters.Authority,
                    AuthenticationParameters.GraphResourceUri,
                    AuthenticationParameters.ApplicationId,
                    AuthenticationParameters.ReturnUri);

                var userInfo = authenticationResult.UserInfo;

                if  (userInfo != null)
                {
                    var userName = $"{userInfo.GivenName} {userInfo.FamilyName}";
                    await DisplayAlert("Success", userName, "Ok");
                    await Navigation.PushModalAsync(new MainTabPage());
                }


            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }


    }
}
