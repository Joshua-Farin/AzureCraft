using System.ComponentModel.DataAnnotations;

namespace AzureCraft.Portal.Models
{
	public class AuthenticationUserModel
	{
		[Required(ErrorMessage = "Email Address is Required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		public string Password { get; set; }
	}
}
