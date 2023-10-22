using Microsoft.Data.SqlClient;
using System.Text;

namespace _08._Increase_Minion_Age
{
       internal class StartUp
       {
              static void Main(string[] args)
              {
                     int[] minionsIds = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                     StringBuilder sb = new StringBuilder();

                     SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();

                     SqlCommand updateMinionsCmd = new SqlCommand(SQLQueries.UpdateMinionsById, connection);
                     for (int i = 0; i < minionsIds.Length; i++)
                     {
                            updateMinionsCmd.Parameters.AddWithValue("@Id", minionsIds[i]);

                            updateMinionsCmd.ExecuteNonQuery();

                            updateMinionsCmd.Parameters.Clear();
                     }

                     SqlCommand getMinions = new SqlCommand(SQLQueries.SelectNameAndAgeOfMinions, connection);

                     SqlDataReader reader = getMinions.ExecuteReader();

                     while (reader.Read())
                     {
                            string name = reader["Name"].ToString();
                            int age = int.Parse(reader["Age"].ToString());

                            sb.AppendLine($"{name} {age}");

                     }
                     reader.Close();

                     Console.WriteLine(sb.ToString().Trim());
              }
       }
}