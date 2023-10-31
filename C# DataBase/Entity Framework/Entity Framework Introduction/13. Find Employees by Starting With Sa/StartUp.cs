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

                     string result = GetEmployeesByFirstNameStartingWithSa(context);

                     Console.WriteLine(result);
              }

              public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     var employees = context.Employees
                                                 .Where(e=>e.FirstName.StartsWith("Sa",StringComparison.OrdinalIgnoreCase))
                                                 .Select(e=>new 
                                                 { 
                                                        e.FirstName,
                                                        e.LastName,
                                                        e.JobTitle,
                                                        Salary = e.Salary.ToString("f2")
                                                 })
                                                 .OrderBy(e=>e.FirstName)
                                                 .ThenBy(e=>e.LastName)
                                                 .ToArray();
                     foreach (var e in employees) 
                     {
                            sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary})");
                     }
                     return sb.ToString().Trim();
              }
       }
}