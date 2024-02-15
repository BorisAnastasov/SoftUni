using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstraints.Category;
namespace Library.Data.Models
{
	public class Category
	{
		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(NameMax)]
		public string Name { get; set; } = null!;

		public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
