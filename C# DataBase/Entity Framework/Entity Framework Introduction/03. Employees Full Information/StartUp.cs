using SoftUni.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace SoftUni
{
       public class StartUp
       {
              static void Main(string[] args)
              {
                     using SoftUniContext db = new SoftUniContext();

                     string result = GetEmployeesFullInformation(db);

                     Console.WriteLine(result);
              }
              public static string GetEmployeesFullInformation(SoftUniContext context)
              {
                     StringBuilder sb = new();

                     var employees = context.Employees
                     .OrderBy(e=> e.EmployeeId)
                            .Select(e => new
                            {
                                   Id = e.EmployeeId,
                                   FirstName = e.FirstName,
                                   MiddleName = e.MiddleName,
                                   LastName = e.LastName,
                                   JobTitle = e.JobTitle,
                                   Salary = e.Salary
                            })
                            .ToList();
                     foreach (var e in employees)
                     {
                            sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
                     }
                     return sb.ToString().Trim();
              }
       }


}