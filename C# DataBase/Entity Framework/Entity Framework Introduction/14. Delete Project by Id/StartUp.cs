using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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

                     string result = DeleteProjectById(context);

                     Console.WriteLine(result);
              }

              public static string DeleteProjectById(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     var project = context.Projects.Find(2);

                     var employeesProjects = context.EmployeesProjects
                                                 .Where(ep => ep.Project == project);
                     foreach (var ep in employeesProjects)
                     {
                            context.EmployeesProjects.Remove(ep);
                     }
                     context.SaveChanges();

                     context.Projects.Remove(project);

                     context.SaveChanges();

                     var projects = context.Projects
                                                 .Take(10);

                     foreach (var p in projects)
                     {
                            sb.AppendLine(p.Name);
                     }

                     return sb.ToString().Trim();
              }
       }
}