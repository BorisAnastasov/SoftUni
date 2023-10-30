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

                     string result = GetEmployee147(context);

                     Console.WriteLine(result);
              }

              public static string GetEmployee147(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     var employee = context.Employees
                                                 .FirstOrDefault(e=>e.EmployeeId ==147);
                     sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

                     var projects = employee.EmployeesProjects.OrderBy(ep=>ep.Project.Name).ToList();

                     foreach (var p in projects)
                     {
                            sb.AppendLine(p.Project.Name);
                     }

                     return sb.ToString().Trim();
              }
       }
}