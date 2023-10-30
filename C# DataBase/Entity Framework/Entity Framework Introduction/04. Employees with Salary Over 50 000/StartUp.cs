using SoftUni.Data;
using System.Text;

namespace SoftUni
{
       public class StartUp
       {
              static void Main(string[] args)
              {
                     using SoftUniContext context = new SoftUniContext();

                     string result = GetEmployeesWithSalaryOver50000(context);

                     Console.WriteLine(result);
              }

              public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
              {
                     StringBuilder sb = new();     
                     var employees = context.Employees
                                   .Where(e => e.Salary > 50000)
                                   .OrderBy(e => e.FirstName)
                                   .Select(e => new
                                   {
                                          Salary = e.Salary,
                                          FirstName = e.FirstName
                                   });
                     foreach (var e in employees) 
                     {
                            sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
                     }

                     return sb.ToString().Trim();
              }
       }
}