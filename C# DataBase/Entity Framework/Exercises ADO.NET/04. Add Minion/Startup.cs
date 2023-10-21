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

                            int? townId = (int)townSelectCmd.ExecuteScalar();

                            if (townId == null)
                            {
                                   SqlCommand townAddCmd = new SqlCommand(SQLQueries.InsertTowns, connection, transaction);
                                   townAddCmd.Parameters.AddWithValue("@townName", townName);
                                   townAddCmd.ExecuteNonQuery();

                                   townId = (int)townSelectCmd.ExecuteScalar();

                                   sb.AppendLine($"Town {townName} was added to the database.");
                            }

                            //villain
                            SqlCommand villainSelectCmd = new SqlCommand(SQLQueries.SelectVillains, connection, transaction);
                            villainSelectCmd.Parameters.AddWithValue("@Name", villainName);

                            int? villainIdObj = (int)villainSelectCmd.ExecuteScalar();

                            if (villainIdObj == null)
                            {
                                   SqlCommand villainAddCmd = new SqlCommand(SQLQueries.InsertVillains, connection, transaction);
                                   villainSelectCmd.Parameters.AddWithValue("@villainName", villainName);
                                   villainAddCmd.ExecuteNonQuery();
                                   sb.AppendLine($"Villain {villainName} was added to the database.");
                                   villainIdObj = (int)villainSelectCmd.ExecuteScalar();
                            }

                            //minion
                            SqlCommand minionSelectCmd = new SqlCommand(SQLQueries.SelectMinions, connection, transaction);
                            minionSelectCmd.Parameters.AddWithValue("@Name", minionName);

                            int? minionIdObj = (int)minionSelectCmd.ExecuteScalar();

                            if (minionIdObj == null)
                            {
                                   SqlCommand minionAddCmd = new SqlCommand(SQLQueries.InsertMinions, connection, transaction);
                                   minionAddCmd.Parameters.AddWithValue("@name", minionName);
                                   minionAddCmd.Parameters.AddWithValue("@age", minionAge);
                                   minionAddCmd.Parameters.AddWithValue("@townId", townId);

                                   minionAddCmd.ExecuteNonQuery();

                                   minionIdObj = (int)minionSelectCmd.ExecuteScalar();
                            }

                            SqlCommand minionVillainCmd = new SqlCommand(SQLQueries.InsertMinionsVillains, connection, transaction);
                            minionVillainCmd.Parameters.AddWithValue("@minionId", minionIdObj);
                            minionVillainCmd.Parameters.AddWithValue("@villainId", villainIdObj);

                            minionVillainCmd.ExecuteNonQuery();

                            sb.AppendLine($"Successfully added {minionName} to be minion of {villainName}.");

                            Console.WriteLine(sb.ToString());

                            transaction.Commit();

                     }
                     catch (Exception e)
                     {
                            transaction.Rollback();
                     }

              }
       }
}