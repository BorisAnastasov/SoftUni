using Microsoft.Data.SqlClient;

namespace _01._Initial_Setup
{
       public class StartUp
       {
              static void Main(string[] args)
              {
                     using SqlConnection connection = new(Config.ConnectionString);
               
                     connection.Open();   

                     Console.WriteLine("Succesful connection!");
              }
       }
}