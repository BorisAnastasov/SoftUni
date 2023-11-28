using AutoMapper;
using ProductShop.Data;
using ProductShop.DTOs.Export;
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

                     //string users = File.ReadAllText("../../../Datasets/users.xml");
                     //string products = File.ReadAllText("../../../Datasets/products.xml");
                     //string categories = File.ReadAllText("../../../Datasets/categories.xml");
                     //string categoriesProducts = File.ReadAllText("../../../Datasets/categories-products.xml");

                     //context.Database.EnsureDeleted();
                     //context.Database.EnsureCreated();

                     //ImportUsers(context, users);
                     //ImportProducts(context, products);
                     //ImportCategories(context, categories);
                     //ImportCategoryProducts(context, categoriesProducts);

                     Console.WriteLine(GetProductsInRange(context));
              }

              //01. Import Users 
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

              //02. Import Products 
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

              //03. Import Categories 
              public static string ImportCategories(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();
                     XmlConverter xmlConverter = new XmlConverter();

                     ImportCategoryDto[] categoryDtos = xmlConverter.Deserializer<ImportCategoryDto>(inputXml, "Categories");

                     var categories = new HashSet<Category>(); 

                     foreach (var categoryDto in categoryDtos)
                     {
                            Category category = mapper.Map<Category>(categoryDto);
                            categories.Add(category);
                     }

                     context.Categories.AddRange(categories);
                     context.SaveChanges();

                     return $"Successfully imported {categoryDtos.Length}";
              }

              //04. Import Categories and Products 
              public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
              {
                     IMapper mapper = InitializeAutoMapper();
                     XmlConverter xmlConverter = new XmlConverter();

                     ImportCategoryProductDto[] categoryProductDtos = xmlConverter
                                                        .Deserializer<ImportCategoryProductDto>
                                                        (inputXml, "CategoryProducts");
                     var categoriesProducts = new HashSet<CategoryProduct>();

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
                            categoriesProducts.Add(categoryProduct);
                     }

                     context.CategoryProducts.AddRange(categoriesProducts);

                     context.SaveChanges();

                     return $"Successfully imported {categoryProductDtos.Length}";
              }

              //05. Export Products In Range 
              public static string GetProductsInRange(ProductShopContext context) 
              {
                     IMapper mapper = InitializeAutoMapper() ;
                     var products = context.Products
                                                 .Where(p => p.Price>=500&&p.Price<=1000)
                                                 .OrderBy(p => p.Price)
                                                 .Take(10)
                                                 .ToArray();
                     var productDtos = new HashSet<ExportProductsInRangeDto>();

                     foreach (var product in products) 
                     { 
                            ExportProductsInRangeDto productDto = mapper.Map<ExportProductsInRangeDto>(product);
                            productDtos.Add(productDto);
                     }

                     XmlConverter xmlConverter = new XmlConverter();

                     string xml = xmlConverter.Serialize(productDtos, "Products");

                     return xml;
              }


              private static IMapper InitializeAutoMapper()
                            => new Mapper(new MapperConfiguration(cfg =>
                            {
                                   cfg.AddProfile<ProductShopProfile>();
                            }));
       }
}