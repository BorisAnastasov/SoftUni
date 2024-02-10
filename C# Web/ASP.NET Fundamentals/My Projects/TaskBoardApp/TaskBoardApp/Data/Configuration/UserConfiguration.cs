using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoardApp.Data.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
	{
		public static IdentityUser testUser = GetUser();
		public void Configure(EntityTypeBuilder<IdentityUser> builder)
		{
			builder.HasData(testUser);
		}

		private static IdentityUser GetUser()
		{
			var hasher = new PasswordHasher<IdentityUser>();

			var user = new IdentityUser()
			{
				UserName = "test@softuni.bg",
				NormalizedUserName = "TEST@SOFTUNI.BG"
			};

			user.PasswordHash = hasher.HashPassword(user, "softuni");

			return user;
		}
	}
}
