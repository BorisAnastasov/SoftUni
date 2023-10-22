using Microsoft.Data.SqlClient;
using System.Text;

namespace _06._Remove_Villain
{
       internal class StartUp
       {
              static void Main(string[] args)
              {
                     int villainId = int.Parse(Console.ReadLine());

                     StringBuilder sb = new StringBuilder();

                     SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();

                     SqlTransaction transaction = connection.BeginTransaction();

                     try
                     {
                            SqlCommand getVillainByIdCmd = new SqlCommand(SQLQueries.GetVillainById, connection, transaction);
                            getVillainByIdCmd.Parameters.AddWithValue("@villainId", villainId);

                            object? villainObj = getVillainByIdCmd.ExecuteScalar();

                            if (villainObj == null)
                            {
                                   Console.WriteLine("No such villain was found.");
                                   return;
                            }

                            string villainName = villainObj.ToString();

                            SqlCommand deleteMinVillCmd = new SqlCommand(SQLQueries.DeleteMinionVillainById, connection, transaction);
                            deleteMinVillCmd.Parameters.AddWithValue("@villainId", villainId);

                            int affectedRows = deleteMinVillCmd.ExecuteNonQuery();

                            SqlCommand deleteVillCmd = new SqlCommand(SQLQueries.DeleteVillainById, connection, transaction);
                            deleteVillCmd.Parameters.AddWithValue("@villainId", villainId);

                            deleteVillCmd.ExecuteNonQuery();

                            sb.AppendLine($"{villainName} was deleted.");

                            sb.AppendLine($"{affectedRows} minions were released.");

                            transaction.Commit();

                     }
                     catch (Exception)
                     {
                            transaction.Rollback();
                            Console.WriteLine("Error");
                     }

                     Console.WriteLine(sb.ToString().Trim());
              }
       }
}