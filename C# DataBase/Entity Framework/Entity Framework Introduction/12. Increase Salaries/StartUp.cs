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

                     string result = IncreaseSalaries(context);

                     Console.WriteLine(result);
              }

              public static string IncreaseSalaries(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     var departmentTypesForIncrese = new[] { "Engineering", "Tool Design", "Marketing", "Information Services" };

                     var employees = context.Employees
                                                 .Where(e => departmentTypesForIncrese.Contains(e.Department.Name))
                                                 .ToArray();

                     foreach (var e in employees)
                     {
                            e.Salary *= (decimal)1.12;
                     }

                     context.SaveChanges();

                     var increaseSalaryEmployees = employees
                                                               .Select(e => new
                                                               {
                                                                      e.FirstName,
                                                                      e.LastName,
                                                                      Salary = e.Salary.ToString("f2")
                                                               })
                                                               .OrderBy(e => e.FirstName)
                                                               .ThenBy(e => e.LastName)
                                                               .ToArray();
                     foreach (var e in increaseSalaryEmployees)
                     {
                            sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary})");
                     }

                     return sb.ToString().Trim();
              }
       }
}