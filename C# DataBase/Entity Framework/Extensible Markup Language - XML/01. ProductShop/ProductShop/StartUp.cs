using AutoMapper;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProductShop
{
       public class StartUp
       {
              public static void Main()
              {
                     ProductShopContext context = new ProductShopContext();

                     string users = File.ReadAllText("../../../Datasets/users.xml");
                     string products = File.ReadAllText("../../../Datasets/products.xml");
                     string categories = File.ReadAllText("../../../Datasets/categories.xml");
                     string categoriesProducts = File.ReadAllText("../../../Datasets/categories-products.xml");




                     Console.WriteLine(ImportUsers(context, users));
              }

              public static string ImportUsers(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();
                     var serializer = new XmlSerializer(typeof(ImportUserDTO[]),
                                                               new XmlRootAttribute("Users"));

                     ImportUserDTO[] userDtos;

                     using (StringReader reader = new StringReader(inputXml))
                     { 
                            userDtos = (ImportUserDTO[])serializer.Deserialize(reader);
                     }
                     foreach (var userDto in userDtos)
                     {
                            User user = mapper.Map<User>(userDto);
                            context.Users.Add(user);
                     }
                     context.SaveChanges();

                     return $"Successfully imported {userDtos.Length}";
              }







              private static IMapper InitializeAutoMapper()
                            => new Mapper(new MapperConfiguration(cfg =>
                            {
                                   cfg.AddProfile<ProductShopProfile>();
                            }));
       }
}