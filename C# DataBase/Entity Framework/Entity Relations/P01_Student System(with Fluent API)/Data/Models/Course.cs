using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace P01_StudentSystem.Data.Models;

public class Course
{
       public Course()
       {
              StudentsCourses = new HashSet<StudentCourse>();
              Resources = new HashSet<Resource>();
              Homeworks = new HashSet<Homework>();

       }
       public int CourseId { get; set; }
       [Required]
       public string Name { get; set; }
       public string Description { get; set; }
       [Required]
       public DateTime StartDate { get; set; }
       [Required]
       public DateTime EndDate { get; set; }
       [Required]
       public decimal Price { get; set; }
       public ICollection<StudentCourse> StudentsCourses { get; set; }
       public ICollection<Resource> Resources { get; set; }
       public ICollection<Homework> Homeworks { get; set; }

}

