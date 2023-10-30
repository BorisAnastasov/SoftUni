using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{
       public class StartUp
       {
              static void Main(string[] args)
              {
                     using SoftUniContext context = new SoftUniContext();

                     string result = AddNewAddressToEmployee(context);

                     Console.WriteLine(result);
              }

              public static string AddNewAddressToEmployee(SoftUniContext context)
              {
                     Address newAddress = new Address()
                     {
                            AddressText = "Vitoshka 15",
                            TownId = 4
                     };
                     //context.Addresses.Add(newAddress);
                     Employee? employee = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");

                     employee.Address = newAddress;

                     context.SaveChanges();

                     StringBuilder sb = new StringBuilder();

                     var employees = context.Employees
                                          .OrderByDescending(e => e.AddressId)
                                          .Take(10)
                                          .Select(e => new
                                          {
                                                 e.Address.AddressText
                                          })
                                          .ToArray();

                     foreach (var item in employees)
                     {
                            sb.AppendLine(item.AddressText);
                     }

                     return sb.ToString().Trim();
              }
       }
}