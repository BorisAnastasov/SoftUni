using Microsoft.Data.SqlClient;
using System.Text;

namespace _05._Change_Town_Names_Casing
{
       internal class StartUp
       {
              static void Main(string[] args)
              {
                     string countryName = Console.ReadLine();

                     StringBuilder sb = new StringBuilder();

                     using SqlConnection conection = new SqlConnection(Config.ConnectionString);
                     conection.Open();

                     SqlTransaction transaction = conection.BeginTransaction();

                     try
                     {
                            SqlCommand updateTownsCmd = new SqlCommand(SQLQueries.UpdateTowns, conection, transaction);
                            updateTownsCmd.Parameters.AddWithValue("@countryName", countryName);
                            int affectedRows = updateTownsCmd.ExecuteNonQuery();

                            if (affectedRows == 0)
                            {
                                   Console.WriteLine("No town names were affected.");
                                   return;
                            }

                            sb.AppendLine($"{affectedRows} town names were affected.");

                            SqlCommand selectTownsCmd = new SqlCommand(SQLQueries.SelectTowns, conection, transaction);
                            selectTownsCmd.Parameters.AddWithValue("@countryName", countryName);

                            using (SqlDataReader reader = selectTownsCmd.ExecuteReader()) 
                            {
                                   List<string> towns = new List<string>();
                                   while (reader.Read())
                                   {
                                          towns.Add(reader["Name"].ToString());
                                   }
                                   sb.AppendLine($"[{string.Join(", ", towns)}]");

                            }

                            Console.WriteLine(sb.ToString());

                            transaction.Commit();
                     }
                     catch (Exception)
                     {
                            transaction.Rollback();
                            Console.WriteLine("Error");
                     }

              }
       }
}