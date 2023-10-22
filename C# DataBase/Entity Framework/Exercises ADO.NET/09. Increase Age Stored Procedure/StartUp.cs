using Microsoft.Data.SqlClient;
using System.Text;

namespace _09._Increase_Age_Stored_Procedure
{
       internal class StartUp
       {
              static void Main(string[] args)
              {
                     int minionId = int.Parse(Console.ReadLine());


                     SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();

                     SqlCommand updateMinionCmd = new SqlCommand("usp_GetOlder", connection);

                     updateMinionCmd.CommandType = System.Data.CommandType.StoredProcedure;
                     updateMinionCmd.Parameters.AddWithValue("@Id", minionId);

                     updateMinionCmd.ExecuteNonQuery();

                     SqlCommand selectMinionsCmd = new SqlCommand(SQLQueries.SelectMinions, connection);
                     selectMinionsCmd.Parameters.AddWithValue("@Id", minionId);

                     SqlDataReader reader = selectMinionsCmd.ExecuteReader();
                     reader.Read();

                     string name = reader["Name"].ToString();
                     int age = int.Parse(reader["Age"].ToString());

                     reader.Close();

                     Console.WriteLine($"{name} - {age} years old");

              }
       }
}