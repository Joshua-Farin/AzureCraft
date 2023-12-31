﻿using AzureCraft.API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.API.Library.DataAccess
{
	public class UserData : IUserData
	{
		private readonly ISqlDataAccess _sql;

		public UserData(ISqlDataAccess sql)
		{
			_sql = sql;
		}

		public List<UserModel> GetUserById(string Id)
		{
			var output = _sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", new { Id }, "AzureCraftData");

			return output;
		}

		public void CreateUser(UserModel user)
		{
			_sql.SaveData("dbo.spUser_Insert", new { user.Id, user.FirstName, user.LastName, user.EmailAddress }, "AzureCraftData");
		}
	}
}
