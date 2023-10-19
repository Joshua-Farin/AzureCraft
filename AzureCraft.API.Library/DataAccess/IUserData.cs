using AzureCraft.API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.API.Library.DataAccess
{
	public interface IUserData
	{
		void CreateUser(UserModel user);
		List<UserModel> GetUserById(string Id);
	}
}
