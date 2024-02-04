using Forum.Data.Models;
using Forum.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Data.Configuration
{
	public class PostEntityConfiguration : IEntityTypeConfiguration<Post>
	{
		private readonly PostSeeder _postseeder;

        public PostEntityConfiguration()
        {
            this._postseeder = new PostSeeder();
        }
        public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.
					HasData(this._postseeder.GeneratePosts().ToArray());

		}
	}
}
