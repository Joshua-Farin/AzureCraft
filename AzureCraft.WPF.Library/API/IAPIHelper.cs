using AzureCraft.WPF.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.WPF.Library.API
{
	public interface IAPIHelper
	{
		HttpClient ApiClient { get; }
		void LogOffUser();
		Task<AuthenticatedUser> Authenticate(string username, string password);
		Task GetLoggedInUserInfo(string token);
	}
}
