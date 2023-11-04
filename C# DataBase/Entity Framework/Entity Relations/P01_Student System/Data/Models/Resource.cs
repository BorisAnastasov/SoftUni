﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Resource
{
       [Key]
       public int ResourceId { get; set; }
       [Required]
       [MaxLength(50)]
       [Unicode]
       public string Name { get; set; } = null!;
       [Required]
       [Unicode(false)]
       public string Url { get; set; } = null!;
       [Required]
       public ResourceType ResourceType { get; set; }

       [ForeignKey(nameof(Course))]
       public int CourseId { get; set; }
       public virtual Course Course { get; set; } = null!;
}
