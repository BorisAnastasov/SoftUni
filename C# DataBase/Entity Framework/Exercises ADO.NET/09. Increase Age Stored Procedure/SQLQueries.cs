using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Increase_Age_Stored_Procedure
{
       public static class SQLQueries
       {
              public const string SelectMinions = 
              @"SELECT Name, Age FROM Minions WHERE Id = @Id";
       }
}
