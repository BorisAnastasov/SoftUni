using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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

                     string result = RemoveTown(context);

                     Console.WriteLine(result);
              }

              public static string RemoveTown(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     Town townToDelete = context.Towns.FirstOrDefault(t => t.Name == "Seattle");

                     var addressesToDelete = context.Addresses
                                                        .Where(a=>a.Town == townToDelete)
                                                        .ToArray();

                     int count = addressesToDelete.Length;

                     var employeesToSetAddressToNull = context.Employees
                                                                      .Where(e => addressesToDelete.Contains(e.Address))
                                                                      .ToArray();

                     foreach (var e in employeesToSetAddressToNull)
                     {
                            e.Address = null;
                     }    
                     context.SaveChanges();

                     foreach (var a in addressesToDelete)
                     {
                            context.Addresses.Remove(a);
                     }
                     context.SaveChanges();

                     context.Towns.Remove(townToDelete);
                     context.SaveChanges();

                     sb.AppendLine($"{count} addresses in Seattle were deleted");


                     return sb.ToString().Trim();
              }
       }
}