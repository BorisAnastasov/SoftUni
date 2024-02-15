using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstraints.Book;
namespace Library.Models
{
    public class BookInfoViewModel
    {
        public int Id { get; set; }

        [StringLength(TitleMax,MinimumLength =TitleMin)]
        public string Title { get; set; } = null!;

        [StringLength(AuthorMax,MinimumLength =AuthorMin)]
        public string Author { get; set; } = null!;

        [StringLength(DescriptionMax,MinimumLength =DescriptionMin)]
        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        [Range(RatingMin, RatingMax)]
        public decimal Rating { get; set; }
        public string Category { get; set; } = null!;
    }
}
