using ProductShop.Data;
using ProductShop.Models;
using Newtonsoft.Json;

namespace ProductShop
{
       public class StartUp
       {
              public static void Main()
              {
                     ProductShopContext context = new ProductShopContext();

                     context.Database.EnsureDeleted();
                     context.Database.EnsureCreated();


                     string json = File.ReadAllText("../../../Datasets/users.json");

                     Console.WriteLine(ImportUsers(context, json));

              }

              //01. Import Users 
              public static string ImportUsers(ProductShopContext context, string inputJson)
              {
                     var users = JsonConvert.DeserializeObject<User[]>(inputJson);

                     context.Users.AddRange(users);
                     context.SaveChanges();      

                     return $"Successfully imported {users.Length}";
              }
       }
}