using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Resource
{
       
       public int ResourceId { get; set; }
       [Required]
       public string Name { get; set; }
       [Required]
       public string Url { get; set; }
       [Required]
       public ResourceType ResourceType { get; set; }
       public int CourseId { get; set; }
       public Course Course { get; set;}
}
