using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Increase_Minion_Age
{
       public static class SQLQueries
       {
              public const string UpdateMinionsById =
              @" UPDATE Minions
                 SET Name = LOWER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
               WHERE Id = @Id";

              public const string SelectNameAndAgeOfMinions =
              @"SELECT Name, Age FROM Minions";
       }
}
