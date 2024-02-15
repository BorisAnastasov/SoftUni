using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Data.DataConstraints.Book;

namespace Library.Data.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(TitleMax)]
		public string Title { get; set; } = null!;

		[Required]
		[MaxLength(AuthorMax)]
		public string Author { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMax)]
		public string Description { get; set; } = null!;

		[Required]
		public string ImageUrl { get; set; } = null!;

		[Required]
		[Range(RatingMin,RatingMax)]
        public decimal Rating { get; set; }

		[Required]
		[ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
		[Required]
		public Category Category { get; set; } = null!;
		public ICollection<ApplicationUserBook> ApplicationUsersBooks { get; set; } = new List<ApplicationUserBook>();
	}
}
