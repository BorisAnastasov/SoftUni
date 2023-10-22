using Microsoft.Data.SqlClient;

namespace _03._Minion_Names
{
       internal class StartUp
       {
              static void Main(string[] args)
              {
                     int n = int.Parse(Console.ReadLine());
                     using SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();
                     SqlCommand commandName = new SqlCommand(SQLQueries.GetTheNamesOfVillainsWithThatId, connection);
                     commandName.Parameters.AddWithValue("@Id", n);
                     try
                     {
                            string nameVillain = commandName.ExecuteScalar().ToString();
                            Console.WriteLine($"Villain: {nameVillain}");
                     }
                     catch (NullReferenceException)
                     {
                            Console.WriteLine($"No villain with ID {n} exists in the database.");
                            return;
                     }
                     SqlCommand commandVillains = new SqlCommand(SQLQueries.GetTheMinionsOrdered, connection);
                     commandVillains.Parameters.AddWithValue("@Id", n);
                     SqlDataReader reader = commandVillains.ExecuteReader();
                     if (!reader.Read())
                     {
                            Console.WriteLine("(no minions)");
                            return;
                     }
                     while (reader.Read())
                     {
                            int rowNum = int.Parse(reader["RowNum"].ToString());
                            string name = reader["Name"].ToString();
                            int age = (int)reader["Age"];
                            Console.WriteLine($"{rowNum}. {name} {age}");
                     }
              }
       }
}