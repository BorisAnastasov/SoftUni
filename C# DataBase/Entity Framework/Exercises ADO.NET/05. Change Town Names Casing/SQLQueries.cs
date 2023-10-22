using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Change_Town_Names_Casing
{
       public static class SQLQueries
       {
              public const string UpdateTowns =
              @"UPDATE Towns
                SET Name = UPPER(Name)
               WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";

              public const string SelectTowns = 
              @" SELECT t.Name 
                 FROM Towns as t
                 JOIN Countries AS c ON c.Id = t.CountryCode
                WHERE c.Name = @countryName";
       }
}
