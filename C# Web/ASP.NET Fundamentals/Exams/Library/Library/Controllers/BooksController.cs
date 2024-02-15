using Humanizer;
using Library.Data;
using Library.Data.Models;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Security.Claims;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryDbContext data;

        public BooksController(LibraryDbContext _data)
        {
            data = _data;
        }

        public async Task<IActionResult> All()
        {
            var books = await data.Books.Select(b => new BookInfoViewModel()
            {
                Title = b.Title,
                Description = b.Description,
                Author = b.Author,
                ImageUrl = b.ImageUrl,
                Rating = b.Rating,
                Category = b.Category.Name,
                Id = b.Id
            }).ToListAsync();

            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCollection(int id)
        {
            var book = await data.Books.FindAsync(id);

            if (book == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();

            var mapping = new ApplicationUserBook()
            {
                ApplicationUserId = userId,
                BookId = id
            };

            if (data.ApplicationUsersBooks.Contains(mapping))
            {
                return RedirectToAction("All");
            }

            await data.ApplicationUsersBooks.AddAsync(mapping);
            await data.SaveChangesAsync();

            return RedirectToAction("All");
        }



        public async Task<IActionResult> Mine()
        {
            string userId = GetUserId();
            var books = await data.ApplicationUsersBooks
                                        .AsNoTracking()
                                        .Where(b => b.ApplicationUser.Id == userId)
                                        .Select(b => new BookMineViewModel()
                                        {
                                            Id = b.BookId,
                                            ImageUrl = b.Book.ImageUrl,
                                            Title = b.Book.Title,
                                            Author = b.Book.Author,
                                            Rating = b.Book.Rating.ToString(),
                                            Category = b.Book.Category.Name,
                                            Description = b.Book.Description
                                        }).ToListAsync();

            return View(books);
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }


    }
}
