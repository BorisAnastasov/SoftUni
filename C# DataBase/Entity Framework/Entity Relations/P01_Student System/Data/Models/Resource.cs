﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Resource
{
       [Key]
       [Required]
       public int ResourceId { get; set; }
       [Required]
       [MaxLength(50)]
       [Unicode]
       public string Name { get; set; }
       [Required]
       [Unicode(false)]
       public string Url { get; set; }
       [Required]
       public ResourceType ResourceType { get; set; }
       [Required]
       public int CourseId { get; set; }
       [Required]
       [ForeignKey(nameof(CourseId))]
       public Course Course { get; set;}
}
