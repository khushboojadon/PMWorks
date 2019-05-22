using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace PMWorks
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri);
        void LogOut(string authority, string returnUri);
    }
}
