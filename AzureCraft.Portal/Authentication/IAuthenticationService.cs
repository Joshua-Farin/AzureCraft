using AzureCraft.Portal.Models;

namespace AzureCraft.Portal.Authentication
{
	public interface IAuthenticationService
	{
		Task<AuthenticatedUserModel> Login(AuthenticationUserModel userForAuthentication);
		Task Logout();
	}
}
