using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
       public class StartUp
       {
              public static void Main()
              {
                     CarDealerContext context = new CarDealerContext();

                     context.Database.EnsureDeleted();
                     context.Database.EnsureCreated();


                     string suppliersJson = File.ReadAllText("../../../Datasets/suppliers.json");
                     string partsJson = File.ReadAllText("../../../Datasets/parts.json");
                     string carsJson = File.ReadAllText("../../../Datasets/cars.json");
                     string costumersJson = File.ReadAllText("../../../Datasets/customers.json");
                     string salesJson = File.ReadAllText("../../../Datasets/sales.json");



                     ImportSuppliers(context, suppliersJson);
                     ImportParts(context, partsJson);
                     Console.WriteLine(ImportCars(context, carsJson));

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
                     var cars = JsonConvert.DeserializeObject<Car[]>(inputJson);

                     context.Cars.AddRange(cars);
                     context.SaveChanges();

                     return $"Successfully imported {cars.Length}.";
              }
       }
}