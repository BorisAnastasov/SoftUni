using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Resource
{
       [Key]
       public int ResourceId { get; set; }

       [Required]
       [MaxLength(50)]
       public string Name { get; set; } = null!;

       [Required]
       [Column(TypeName = "varchar(255)")]
       public string Url { get; set; } = null!;

       [Required]
       public ResourceType ResourceType { get; set; }

       [ForeignKey(nameof(Course))]
       public int CourseId { get; set; }
       public Course Course { get; set; } = null!;
}
