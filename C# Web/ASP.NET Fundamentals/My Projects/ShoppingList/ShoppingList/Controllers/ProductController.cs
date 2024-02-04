using Microsoft.AspNetCore.Mvc;
using ShoppingList.Data.Models;
using ShoppingList.Data.Models.Product;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
	public class ProductController : Controller
    {
        private readonly ShoppingListDbContext _data;

        public ProductController(ShoppingListDbContext data) => _data = data;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All() 
        {
            var products = _data.Products.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();

            return View(products);
        }
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(ProductViewModel model) 
        {
            var product = new Product()
            {
                Name = model.Name,
            };

            _data.Products.Add(product);
            _data.SaveChanges();

            return RedirectToAction("All");
        }
        public IActionResult Edit(int id)
        {
            var product = _data.Products.Find(id);

            return View(new ProductViewModel()
            {
                Name = product.Name
            });
        }
        [HttpPost]
        public IActionResult Edit(int id, Product model) 
        {
			var product = _data.Products.Find(id);
            product.Name = model.Name;

            _data.SaveChanges();

            return RedirectToAction("All");
		}

        public IActionResult Delete(int id) 
        {
            var product = _data.Products.Find(id);

            _data.Products.Remove(product);
            _data.SaveChanges();

            return RedirectToAction("All");
        }


    }
}
