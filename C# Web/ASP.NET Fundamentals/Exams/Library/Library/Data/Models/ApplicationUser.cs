using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstraints.ApplicationUser;

namespace Library.Data.Models
{
	public class ApplicationUser
	{
		[Key]
		public string Id { get; set; } = null!;

		[Required]
		[MaxLength(UserNameMax)]
		public string UserName { get; set; } = null!;

		[Required]
		[MaxLength(EmailMax)]
		public string Email { get; set; } = null!;

		[Required]
		[MaxLength(PasswordMax)]
		public string Password { get; set; } = null!;

        public ICollection<ApplicationUserBook> ApplicationUsersBooks { get; set; } = new List<ApplicationUserBook>();	

    }
}
