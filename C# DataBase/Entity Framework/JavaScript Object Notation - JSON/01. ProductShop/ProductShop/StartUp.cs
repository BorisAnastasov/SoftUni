using ProductShop.Data;
using ProductShop.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.WebSockets;

namespace ProductShop
{
       public class StartUp
       {
              public static void Main()
              {
                     ProductShopContext context = new ProductShopContext();

                     //context.Database.EnsureDeleted();
                     //context.Database.EnsureCreated();

                     //string userJson = File.ReadAllText("../../../Datasets/users.json");
                     //string productsJson = File.ReadAllText("../../../Datasets/products.json");
                     //string categoriesJson = File.ReadAllText("../../../Datasets/categories.json");
                     //string categoriesProductsJson = File.ReadAllText("../../../Datasets/categories-products.json");

                     //Console.WriteLine(ImportUsers(context, userJson));
                     //Console.WriteLine(ImportProducts(context, productsJson));
                     //Console.WriteLine(ImportCategories(context, categoriesJson));
                     //Console.WriteLine(ImportCategoryProducts(context, categoriesProductsJson));



                     Console.WriteLine(GetUsersWithProducts(context));
              }

              //01. Import Users 
              public static string ImportUsers(ProductShopContext context, string inputJson)
              {
                     var users = JsonConvert.DeserializeObject<User[]>(inputJson);

                     context.Users.AddRange(users);
                     context.SaveChanges();

                     return $"Successfully imported {users.Length}";
              }

              //02. Import Products 
              public static string ImportProducts(ProductShopContext context, string inputJson)
              {
                     var products = JsonConvert.DeserializeObject<Product[]>(inputJson);

                     context.Products.AddRange(products);
                     context.SaveChanges();

                     return $"Successfully imported {products.Length}";
              }

              //03. Import Categories 
              public static string ImportCategories(ProductShopContext context, string inputJson)
              {
                     var categories = JsonConvert.DeserializeObject<Category[]>(inputJson)
                     .Where(c => c.Name != null)
                     .ToArray();

                     context.Categories.AddRange(categories);
                     context.SaveChanges();

                     return $"Successfully imported {categories.Length}";
              }

              //04. Import Categories and Products 
              public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
              {
                     var catProd = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);


                     context.CategoriesProducts.AddRange(catProd);
                     context.SaveChanges();

                     return $"Successfully imported {catProd.Length}";
              }

              //05. Export Products In Range 
              public static string GetProductsInRange(ProductShopContext context)
              {
                     var products = context.Products
                                                 .Where(p => p.Price >= 500 && p.Price <= 1000)
                                                 .OrderBy(p => p.Price)
                                                 .Select(p => new
                                                 {
                                                        p.Name,
                                                        p.Price,
                                                        Seller = p.Seller.FirstName + " " + p.Seller.LastName
                                                 })
                                                 .ToArray();

                     JsonSerializerSettings settings = new JsonSerializerSettings()
                     {
                            Formatting = Formatting.Indented,
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                     };
                     string json = JsonConvert.SerializeObject(products, settings);

                     return json;
              }

              //06. Export Sold Products 
              public static string GetSoldProducts(ProductShopContext context)
              {
                     var products = context.Users
                                                 .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(p => p.Buyer != null))
                                                 .OrderBy(u => u.LastName)
                                                 .ThenBy(u => u.FirstName)
                                                 .Select(u => new
                                                 {
                                                        u.FirstName,
                                                        u.LastName,
                                                        SoldProducts = u.ProductsSold
                                                                             .Where(p => p.Buyer != null)
                                                                             .Select(p => new
                                                                             {
                                                                                    p.Name,
                                                                                    p.Price,
                                                                                    BuyerFirstName = p.Buyer.FirstName,
                                                                                    BuyerLastName = p.Buyer.LastName
                                                                             })
                                                                             .ToArray()
                                                 })
                                                 .ToArray();
                     JsonSerializerSettings settings = new()
                     {
                            Formatting = Formatting.Indented,
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                     };

                     string json = JsonConvert.SerializeObject(products, settings);

                     return json;
              }

              //07. Export Categories By Products Count 
              public static string GetCategoriesByProductsCount(ProductShopContext context)
              {
                     var categories = context.Categories
                                                 .OrderByDescending(c => c.CategoriesProducts.Count)
                                                 .Select(c => new
                                                 {
                                                        Category = c.Name,
                                                        ProductsCount = c.CategoriesProducts.Count,
                                                        AveragePrice = c.CategoriesProducts.Average(cp => cp.Product.Price).ToString("f2"),
                                                        TotalRevenue = c.CategoriesProducts.Sum(cp => cp.Product.Price).ToString("f2")
                                                 })
                                                 .ToArray();
                     JsonSerializerSettings settings = new()
                     {
                            Formatting = Formatting.Indented,
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                     };

                     string json = JsonConvert.SerializeObject (categories, settings);

                     return json;

              }

              //08. Export Users and Products 
              public static string GetUsersWithProducts(ProductShopContext context)
              {
                     var users = context.Users
                                          .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                                          .OrderByDescending(u => u.ProductsSold.Count(p => p.Buyer != null))
                                          .Select(u => new 
                                          { 
                                                 u.FirstName,
                                                 u.LastName,
                                                 u.Age,
                                                 SoldProducts = new 
                                                 { 
                                                        Count = u.ProductsSold.Count(p => p.Buyer != null),
                                                        Products = u.ProductsSold
                                                                      .Where(p=>p.Buyer != null)
                                                                      .Select(p => new 
                                                                      {
                                                                             p.Name,
                                                                             p.Price,
                                                                      })
                                                                      .ToArray()
                                                 },
                                          })
                                          .ToArray();

                     object obj = new
                     {
                            UsersCount = users.Length,
                            Users = users
                     };

                     JsonSerializerSettings settings = new()
                     {
                            Formatting = Formatting.Indented,
                            ContractResolver = new CamelCasePropertyNamesContractResolver(),
                            NullValueHandling = NullValueHandling.Ignore
                     };

                     string json = JsonConvert.SerializeObject(obj,settings);

                     return json;


              }
       }
}