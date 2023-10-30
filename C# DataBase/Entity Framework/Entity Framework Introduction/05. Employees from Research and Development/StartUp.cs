using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using System.Text;

namespace SoftUni
{
       public class StartUp
       {
              static void Main(string[] args)
              {
                     using SoftUniContext context = new SoftUniContext();

                     string result = GetEmployeesFromResearchAndDevelopment(context);

                     Console.WriteLine(result);
              }

              public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
              {
                     var employees = context.Employees
                                              .Where(e => e.Department.Name == "Research and Development")
                                              .OrderBy(e => e.Salary)
                                              .ThenByDescending(e => e.FirstName)
                                              .Select(e => new
                                              {
                                                     FirstName = e.FirstName,
                                                     LastName = e.LastName,
                                                     Department = e.Department.Name,
                                                     Salary = e.Salary
                                              });

                     StringBuilder sb = new StringBuilder();
                     foreach (var e in employees)
                     {
                            sb.AppendLine($"{e.FirstName} {e.LastName} from {e.Department} - ${e.Salary:f2}");
                     }

                     return sb.ToString().Trim();

              }
       }
}