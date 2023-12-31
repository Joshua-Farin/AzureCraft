﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.WPF.Library.Models
{
	public interface ILoggedInUserModel
	{
		DateTime CreateDate { get; set; }
		string EmailAddress { get; set; }
		string FirstName { get; set; }
		string Id { get; set; }
		string LastName { get; set; }
		string Token { get; set; }
		void ResetUserModel();
	}
}
