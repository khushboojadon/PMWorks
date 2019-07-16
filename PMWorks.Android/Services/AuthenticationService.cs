using System;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Webkit;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;

[assembly: Dependency(typeof(PMWorks.Droid.Services.AuthenticationService))]
namespace PMWorks.Droid.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri)
        {
            var authContext = new AuthenticationContext(authority);
            if (authContext.TokenCache.ReadItems().Any())
                authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);

            var uri = new Uri(returnUri);
            var platformParams = new PlatformParameters((Activity)Forms.Context);
            var authResult = await authContext.AcquireTokenAsync(resource, clientId, uri, platformParams);
            return authResult;
        }

        public void LogOut(string authority, string returnUri)
        {
            var authContext = new AuthenticationContext(authority);
            authContext.TokenCache.Clear();

            CookieManager.Instance.RemoveAllCookie();
        }
    }
}
