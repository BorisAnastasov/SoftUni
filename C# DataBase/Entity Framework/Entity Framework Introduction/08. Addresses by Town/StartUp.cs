﻿using SoftUni.Data;
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

                     string result = GetAddressesByTown(context);

                     Console.WriteLine(result);
              }

              public static string GetAddressesByTown(SoftUniContext context)
              {
                     StringBuilder sb = new StringBuilder();

                     
                     return sb.ToString().Trim();
              }
       }
}