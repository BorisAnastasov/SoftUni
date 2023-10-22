using _01._Initial_Setup;
using _03._Minion_Names;
using Microsoft.Data.SqlClient;
using System.Text;

namespace _07._Print_All_Minion_Names
{
       internal class StartUp
       {
              static void Main(string[] args)
              {
                     SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();

                     SqlCommand cmd = new SqlCommand(SQLQueries.SelectNames, connection);

                     SqlDataReader reader = cmd.ExecuteReader();

                     List<string> names = new List<string>();
                     while (reader.Read())
                     {
                            names.Add(reader["Name"].ToString());
                     }
                     reader.Close();
                     StringBuilder sb = new StringBuilder();


                     while (names.Any())  
                     {
                            sb.AppendLine(names[0]);
                            names.RemoveAt(0);
                            if (names.Any())
                            {
                                   sb.AppendLine(names[names.Count - 1]);
                                   names.RemoveAt(names.Count - 1);
                            }
                     }

                     Console.WriteLine(sb.ToString().Trim());


              }
       }
}