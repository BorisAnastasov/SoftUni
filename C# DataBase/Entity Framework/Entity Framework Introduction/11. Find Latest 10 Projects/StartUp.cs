using SoftUni.Data;
using SoftUni.Models;
using System.Globalization;
using System.Text;

namespace SoftUni
{
       public class StartUp
       {
              static void Main(string[] args)
              {
                     using SoftUniContext context = new SoftUniContext();

                     string result = GetLatestProjects(context);

                     Console.WriteLine(result);
              }

              public static string GetLatestProjects(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     var projects = context.Projects
                                                 .OrderByDescending(p => p.StartDate)
                                                 .Take(10)
                                                 .OrderBy(p => p.Name)
                                                 .Select(p => new
                                                 {
                                                        p.Name,
                                                        p.Description,
                                                        StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture)
                                                 })
                                                 .ToArray();
                     foreach (var p in projects)
                     {
                            sb.AppendLine(p.Name);
                            sb.AppendLine(p.Description);
                            sb.AppendLine(p.StartDate);
                     }
                     return sb.ToString().Trim();
              }
       }
}