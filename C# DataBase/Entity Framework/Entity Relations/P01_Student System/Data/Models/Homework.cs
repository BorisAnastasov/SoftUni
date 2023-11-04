﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Homework
{
       [Key]
       [Required]
       public int HomeworkId { get; set; }
       [Unicode(false)]
       [Required]
       public string Content { get; set; }
       [Required]
       public ContentType ContentType { get; set; }
       [Required]
       public DateTime SubmissionTime { get; set; }
       [Required]
       public int StudentId { get; set; }
       [Required]
       [ForeignKey(nameof(StudentId))]
       public Student Student { get; set; }
       [Required]
       public int CourseId { get; set; }
       [Required]
       [ForeignKey(nameof(CourseId))]
       public Course Course { get; set; }
}
