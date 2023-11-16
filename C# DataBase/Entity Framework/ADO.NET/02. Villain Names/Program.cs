using Microsoft.Data.SqlClient;

namespace _02._Villain_Names
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
                     {
                            connection.Open();
                            SqlCommand sqlCommand = new SqlCommand(@"
                              SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                                FROM Villains AS v 
                                JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                              GROUP BY v.Id, v.Name 
                              HAVING COUNT(mv.VillainId) > 3 
                              ORDER BY COUNT(mv.VillainId)
                            ", connection);
                            SqlDataReader reader = sqlCommand.ExecuteReader();
                            while (reader.Read())
                            {
                                   Console.WriteLine($"{reader["Name"]} - {reader["MinionsCount"]}");
                            }

                     }
              }
       }
}