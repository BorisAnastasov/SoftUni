using CarDealer.Data;
using CarDealer.Models;
using CarDealer.Models.DTOs;
using Newtonsoft.Json;

namespace CarDealer
{
       public class StartUp
       {
              public static void Main()
              {
                     CarDealerContext context = new CarDealerContext();

                     //context.Database.EnsureDeleted();
                     //context.Database.EnsureCreated();

                     //string suppliersJson = File.ReadAllText("../../../Datasets/suppliers.json");
                     //string partsJson = File.ReadAllText("../../../Datasets/parts.json");
                     //string carsJson = File.ReadAllText("../../../Datasets/cars.json");
                     //string costumersJson = File.ReadAllText("../../../Datasets/customers.json");
                     //string salesJson = File.ReadAllText("../../../Datasets/sales.json");

                     //ImportSuppliers(context, suppliersJson);
                     //ImportParts(context, partsJson);
                     //ImportCars(context, carsJson);
                     //ImportCustomers(context, costumersJson);
                     //Console.WriteLine(ImportSales(context, salesJson));

                     Console.WriteLine(GetCarsFromMakeToyota(context));
              }

              //09. Import Suppliers 
              public static string ImportSuppliers(CarDealerContext context, string inputJson)
              {
                     var suppliers = JsonConvert.DeserializeObject<Supplier[]>(inputJson);

                     context.Suppliers.AddRange(suppliers);
                     context.SaveChanges();

                     return $"Successfully imported {suppliers.Length}.";
              }

              // 10. Import Parts
              public static string ImportParts(CarDealerContext context, string inputJson)
              {
                     var ids = context.Suppliers.Select(s => s.Id);

                     var parts = JsonConvert.DeserializeObject<Part[]>(inputJson)!
                         .Where(p => ids.Contains(p.SupplierId))
                         .ToArray();
                     context.Parts.AddRange(parts);
                     context.SaveChanges();

                     return $"Successfully imported {parts.Length}.";
              }

              //11. Import Cars 
              public static string ImportCars(CarDealerContext context, string inputJson)
              {
                     var carsDto = JsonConvert.DeserializeObject<CarDto[]>(inputJson)!;

                     foreach (var carDto in carsDto)
                     {
                            Car car = new Car()
                            {
                                   Make = carDto.Make,
                                   Model = carDto.Model,
                                   TraveledDistance = carDto.TraveledDistance
                            };
                            context.Cars.Add(car);

                            foreach (var partId in carDto.PartsId.Distinct())
                            {
                                   PartCar partCar = new PartCar()
                                   {
                                          Car = car,
                                          PartId = partId
                                   };
                                   context.PartsCars.Add(partCar);
                            }
                     }
                     context.SaveChanges();

                     return $"Successfully imported {carsDto.Length}.";
              }

              //12. Import Customers 
              public static string ImportCustomers(CarDealerContext context, string inputJson)
              {
                     var customers = JsonConvert.DeserializeObject<Customer[]>(inputJson);

                     context.Customers.AddRange(customers);
                     context.SaveChanges();

                     return $"Successfully imported {customers.Length}.";
              }

              //13. Import Sales 
              public static string ImportSales(CarDealerContext context, string inputJson)
              {
                     var sales = JsonConvert.DeserializeObject<Sale[]>(inputJson);

                     context.Sales.AddRange(sales);
                     context.SaveChanges();

                     return $"Successfully imported {sales.Length}.";
              }

              //14. Export Ordered Customers 
              public static string GetOrderedCustomers(CarDealerContext context)
              {
                     var customers = context.Customers
                                                 .OrderBy(c => c.BirthDate)
                                                 .ThenBy(c => c.IsYoungDriver)
                                                 .Select(c=>new 
                                                 { 
                                                        c.Name,
                                                        BirthDate = c.BirthDate.ToString("dd/MM/yyyy"), 
                                                        c.IsYoungDriver
                                                 })
                                                 .ToArray();
                     JsonSerializerSettings settings = new()
                     {
                            Formatting = Formatting.Indented
                     };

                     string json = JsonConvert.SerializeObject(customers, settings);

                     return json;
              }

              //15. Export Cars From Make Toyota 
              public static string GetCarsFromMakeToyota(CarDealerContext context) 
              {
                     var cars = context.Cars
                                          .Where(c => c.Make == "Toyota")
                                          .OrderBy(c => c.Model)
                                          .ThenByDescending(c => c.TraveledDistance)
                                          .Select(c => new
                                          {
                                                 c.Id,
                                                 c.Make,
                                                 c.Model,
                                                 c.TraveledDistance
                                          })
                                          .ToArray();
                     JsonSerializerSettings settings = new()
                     {
                            Formatting = Formatting.Indented
                     };

                     string json = JsonConvert.SerializeObject (cars, settings);

                     return json;
              }

              //16. Export Local Suppliers 
              public static string GetLocalSuppliers(CarDealerContext context) 
              { 
                     
              }
       }
}