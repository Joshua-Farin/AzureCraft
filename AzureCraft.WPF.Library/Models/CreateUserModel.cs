using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.WPF.Library.Models
{
	public class CreateUserModel
	{
		[Required]
		[DisplayName("First Name")]
		public string FirstName { get; set; }
		[Required]
		[DisplayName("Last Name")]
		public string LastName { get; set; }
		[Required]
		[EmailAddress]
		[DisplayName("Email Address")]
		public string EmailAddress { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		[Compare(nameof(Password), ErrorMessage = "The passwords do not match")]
		[DisplayName("Confirm Password")]
		public string ConfirmPassword { get; set; }
	}
}
