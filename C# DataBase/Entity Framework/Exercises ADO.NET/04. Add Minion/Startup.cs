using _01._Initial_Setup;
using Microsoft.Data.SqlClient;
using System.Text;

namespace _04._Add_Minion
{
       internal class Startup
       {
              static void Main(string[] args)
              {
                     string[] inputMinion = Console.ReadLine().Split(" ").Skip(1).ToArray();
                     string villainName = Console.ReadLine().Split(" ").Skip(1).ToArray()[0];

                     string minionName = inputMinion[0];
                     int minionAge = int.Parse(inputMinion[1]);
                     string townName = inputMinion[2];


                     using SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();

                     StringBuilder sb = new StringBuilder();

                     SqlTransaction transaction = connection.BeginTransaction();

                     try
                     {
                            //town
                            SqlCommand townSelectCmd = new SqlCommand(SQLQueries.SelectTowns, connection, transaction);
                            townSelectCmd.Parameters.AddWithValue("@townName", townName);

                            object? townObj = townSelectCmd.ExecuteScalar();

                            if (townObj == null)
                            {
                                   SqlCommand townAddCmd = new SqlCommand(SQLQueries.InsertTowns, connection, transaction);
                                   townAddCmd.Parameters.AddWithValue("@townName", townName);
                                   townAddCmd.ExecuteNonQuery();

                                   sb.AppendLine($"Town {townName} was added to the database.");
                            }

                            int townId = (int)townSelectCmd.ExecuteScalar();

                            //villain
                            SqlCommand villainSelectCmd = new SqlCommand(SQLQueries.SelectVillains, connection, transaction);
                            villainSelectCmd.Parameters.AddWithValue("@Name", villainName);

                            object? villainObj = villainSelectCmd.ExecuteScalar();
                            if (villainObj == null)
                            {
                                   SqlCommand villainAddCmd = new SqlCommand(SQLQueries.InsertVillains, connection, transaction);
                                   villainAddCmd.Parameters.AddWithValue("@villainName", villainName);
                                   villainAddCmd.ExecuteNonQuery();
                                   sb.AppendLine($"Villain {villainName} was added to the database.");
                            }

                            int villainId = (int)villainSelectCmd.ExecuteScalar();

                            //minion
                            SqlCommand minionSelectCmd = new SqlCommand(SQLQueries.SelectMinions, connection, transaction);
                            minionSelectCmd.Parameters.AddWithValue("@Name", minionName);

                            object? minionObj = minionSelectCmd.ExecuteScalar();
                            if (minionObj == null)
                            {
                                   SqlCommand minionAddCmd = new SqlCommand(SQLQueries.InsertMinions, connection, transaction);
                                   minionAddCmd.Parameters.AddWithValue("@name", minionName);
                                   minionAddCmd.Parameters.AddWithValue("@age", minionAge);
                                   minionAddCmd.Parameters.AddWithValue("@townId", townId);

                                   minionAddCmd.ExecuteNonQuery();

                                   
                            }
                            int minionId = (int)minionSelectCmd.ExecuteScalar();


                            if (minionObj == null || villainObj == null)
                            {
                                   SqlCommand minionVillainCmd = new SqlCommand(SQLQueries.InsertMinionsVillains, connection, transaction);
                                   minionVillainCmd.Parameters.AddWithValue("@minionId", minionId);
                                   minionVillainCmd.Parameters.AddWithValue("@villainId", villainId);

                                   minionVillainCmd.ExecuteNonQuery();
                            }

                            sb.AppendLine($"Successfully added {minionName} to be minion of {villainName}.");

                            Console.WriteLine(sb.ToString());

                            transaction.Commit();

                     }
                     catch (Exception)
                     {
                            transaction.Rollback();
                            Console.WriteLine("Error!");
                     }

              }
       }
}