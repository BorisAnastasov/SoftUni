using AutoMapper;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
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

                     context.Database.EnsureDeleted();
                     context.Database.EnsureCreated();

                     ImportUsers(context, users);

                     Console.WriteLine(ImportProducts(context, products));
              }
              public static string ImportUsers(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();
                     var serializer = new XmlSerializer(typeof(ImportUserDto[]),
                                                               new XmlRootAttribute("Users"));

                     ImportUserDto[] userDtos;

                     using (StringReader reader = new StringReader(inputXml))
                     {
                            userDtos = (ImportUserDto[])serializer.Deserialize(reader);
                     }
                     foreach (var userDto in userDtos)
                     {
                            User user = mapper.Map<User>(userDto);
                            context.Users.Add(user);
                     }
                     context.SaveChanges();

                     return $"Successfully imported {userDtos.Length}";
              }

              public static string ImportProducts(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();

                     XmlConverter xmlConverter = new XmlConverter();

                     ImportProductDto[] productDtos = xmlConverter.Deserializer<ImportProductDto>(inputXml, "Products");

                     var products = new HashSet<Product>();


                     foreach (var productDto in productDtos)
                     {
                            Product product = mapper.Map<Product>(productDto);

                            products.Add(product);
                     }
                     context.Products.AddRange(products);
                     context.SaveChanges();

                     return $"Successfully imported {productDtos.Length}";
              }

              public static string ImportCategories(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();
                     XmlConverter xmlConverter = new XmlConverter();

                     ImportCategoryDto[] categoryDtos = xmlConverter.Deserializer<ImportCategoryDto>(inputXml, "Categories");


                     foreach (var categoryDto in categoryDtos)
                     {
                            Category category = mapper.Map<Category>(categoryDto);
                            context.Categories.Add(category);
                     }

                     context.SaveChanges();

                     return $"Successfully imported {categoryDtos.Length}";
              }

              public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();
                     XmlConverter xmlConverter = new XmlConverter();

                     ImportCategoryProductDto[] categoryProductDtos = xmlConverter
                                                        .Deserializer<ImportCategoryProductDto>
                                                        (inputXml, "CategoryProducts");


                     foreach (var categoryProductDto in categoryProductDtos)
                     {
                            int categoryId = categoryProductDto.CategoryId;
                            int productId = categoryProductDto.ProductId;

                            if (categoryId == null || context.Categories.All(c => c.Id == categoryId))
                            {
                                   continue;
                            }

                            if (productId == null || context.Products.All(p => p.Id == productId))
                            {
                                   continue;
                            }

                            CategoryProduct categoryProduct = mapper.Map<CategoryProduct>(categoryProductDto);
                            context.CategoryProducts.Add(categoryProduct);
                     }

                     context.SaveChanges();

                     return $"Successfully imported {categoryProductDtos.Length}";
              }

              public static string GetProductsInRange(ProductShopContext context) 
              {

                     var products = context.Products
                                                 .Where(p => p.Price>=500&&p.Price<=1000)
                                                 .OrderBy(p => p.Price)
                                                 .Take(10)
                                                 .Select(p=>new 
                                                 { 
                                                        ProductName = p.Name,
                                                        p.Price,
                                                        Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                                                 })
                                                 .ToArray();

                     
                     XmlConverter xmlConverter = new XmlConverter();
                     string xml = xmlConverter.Serialize(products, "Products");

                     return xml;
              }


              private static IMapper InitializeAutoMapper()
                            => new Mapper(new MapperConfiguration(cfg =>
                            {
                                   cfg.AddProfile<ProductShopProfile>();
                            }));
       }
}