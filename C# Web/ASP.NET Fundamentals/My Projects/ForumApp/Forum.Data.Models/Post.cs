using System.ComponentModel.DataAnnotations;
using static Forum.Common.EntityValidations.Post;

namespace Forum.Data.Models
{
	public class Post
	{
        [Key]
        public Guid Id { get; init; }
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
