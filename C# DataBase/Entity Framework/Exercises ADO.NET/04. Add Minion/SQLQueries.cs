using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Add_Minion
{
       public static class SQLQueries
       {
              public const string SelectVillains = @"SELECT Id FROM Villains WHERE Name = @Name";

              public const string SelectMinions = @"SELECT Id FROM Minions WHERE Name = @Name";

              public const string InsertMinionsVillains = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";

              public const string InsertVillains = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";

              public const string InsertMinions = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";

              public const string InsertTowns = @"INSERT INTO Towns (Name) VALUES (@townName)";

              public const string SelectTowns = @"SELECT Id FROM Towns WHERE Name = @townName";
       }
}
