using System;
using System.Linq;
using System.Threading.Tasks;
using Foundation;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;


[assembly: Dependency(typeof(PMWorks.iOS.Services.AuthenticationService))]
namespace PMWorks.iOS.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri)
        {
            var authContext = new AuthenticationContext(authority);
            if (authContext.TokenCache.ReadItems().Any())
                authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);

            var controller = AppDelegate.keywindow.RootViewController;
           
            var uri = new Uri(returnUri);
            var platformParams = new PlatformParameters(controller);
            var authResult = await authContext.AcquireTokenAsync(resource, clientId, uri, platformParams);
            return authResult;
        }

        public void LogOut(string authority,string returnUri)
        {
            var authContext = new AuthenticationContext(authority);
            authContext.TokenCache.Clear();

            NSHttpCookieStorage CookieStorage = NSHttpCookieStorage.SharedStorage;

            foreach (var cookie in CookieStorage.Cookies)
            {
                CookieStorage.DeleteCookie(cookie);
            }
        }
    }
}
