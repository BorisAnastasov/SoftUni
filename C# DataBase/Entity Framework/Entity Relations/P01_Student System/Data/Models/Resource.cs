using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Resource
{
       public enum ResourceEnum
       {
              Video,
              Presentation,
              Document,
              Other
       }
       public int ResourceId { get; set; }
       public string Name { get; set; }
       public string Url { get; set; }
       public ResourceEnum ResourceType { get; set; }
       public int CourseId { get; set; }
       public Course Course { get; set;}
}
