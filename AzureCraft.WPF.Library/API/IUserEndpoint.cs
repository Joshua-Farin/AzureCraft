using AzureCraft.WPF.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.WPF.Library.API
{
	public interface IUserEndpoint
	{
		Task<List<UserModel>> GetAll();
		Task<Dictionary<string, string>> GetAllRoles();
		Task AddUserToRole(string userId, string roleName);
		Task RemoveUserFromRole(string userId, string roleName);
		Task CreateUser(CreateUserModel model);
	}
}
