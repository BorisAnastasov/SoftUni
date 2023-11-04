using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace P01_StudentSystem.Data.Models;

public class Student
{

       public Student()
       {
              StudentsCourses = new HashSet<StudentCourse>();
              Homeworks = new HashSet<Homework>();
       }
       [Key]
       public int StudentId { get; set; }
       [MaxLength(100)]
       [Unicode]
       public string Name { get; set; }
       [MaxLength(10)]
       [MinLength(10)]
       [Unicode(false)]
       public string? PhoneNumber { get; set; }
       public DateTime RegisteredOn { get; set; }
       public DateTime? Birthday { get; set; }

       public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
       public virtual ICollection<Homework> Homeworks { get; set; }

}

