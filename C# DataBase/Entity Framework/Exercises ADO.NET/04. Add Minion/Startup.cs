using _01._Initial_Setup;
using Microsoft.Data.SqlClient;

namespace _04._Add_Minion
{
       internal class Startup
       {
              static void Main(string[] args)
              {
                     string[] inputMinion = Console.ReadLine().Split(" ").Skip(1).ToArray();
                     string nameVillain = Console.ReadLine().Split(" ").Skip(1).ToArray()[0];

                     string nameMinion = inputMinion[0];
                     int nameAge = int.Parse(inputMinion[1]);
                     string townMinion = inputMinion[2];



                     using SqlConnection connection = new SqlConnection(Config.ConnectionString);
                     connection.Open();

                     object? 
                     


                     try
                     {
                            SqlCommand sqlCommandVillain = new SqlCommand(SQLQueries.SelectVillains, connection);
                            sqlCommandVillain.Parameters.AddWithValue("@Name", nameVillain);
                            SqlDataReader reader = sqlCommandVillain.ExecuteReader();


                     }
                     catch (Exception)
                     {

                            throw;
                     }

              }
       }
}