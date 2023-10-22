using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Minion_Names
{
       public static class SQLQueries
       {
              public const string GetVillainById =
              @"SELECT Name FROM Villains WHERE Id = @villainId";

              public const string DeleteMinionVillainById =
              @"DELETE FROM MinionsVillains 
                     WHERE VillainId = @villainId";

              public const string DeleteVillainById =
              @"DELETE FROM Villains
                      WHERE Id = @villainId";
       }
}
