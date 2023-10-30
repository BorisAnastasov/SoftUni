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

                     string result = GetEmployeesInPeriod(context);

                     Console.WriteLine(result);
              }

              public static string GetEmployeesInPeriod(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     var employees = context.Employees
                                                 .Take(10)
                                                 .Select(e => new
                                                 {
                                                        e.FirstName,
                                                        e.LastName,
                                                        ManagerName = e.Manager.FirstName + ' ' + e.Manager.LastName,
                                                        Projects = e.EmployeesProjects
                                                                      .Where(p => p.Project.StartDate.Year >= 2001 && 
                                                                                  p.Project.StartDate.Year <= 2003)
                                                                      .Select(ep => new
                                                                      {
                                                                             ProjectName = ep.Project.Name,
                                                                             StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture),
                                                                             EndDate = ep.Project.EndDate.HasValue ? 
                                                                                                         ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) : "not finished"
                                                                      })     
                                                 })
                                                 .ToArray();

                     foreach (var e in employees)
                     {
                            sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerName}");
                            foreach (var item in e.Projects)
                            {
                                   sb.AppendLine($"--{item.ProjectName} - {item.StartDate} - {item.EndDate}");
                            }
                     }
                     
                     return sb.ToString().Trim();
              }
       }
}