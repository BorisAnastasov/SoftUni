namespace BookShop
{
       using BookShop.Models.Enums;
       using Data;
       using Initializer;
       using Microsoft.EntityFrameworkCore;
       using System.Text;
       using System.Linq;

       public class StartUp
       {
              public static void Main()
              {
                     using var db = new BookShopContext();
                     DbInitializer.ResetDatabase(db);

                     string input = Console.ReadLine();

                     string result = GetBooksByCategory(db, input);
                     Console.WriteLine(result);

              }

              //02. Age Restriction 
              public static string GetBooksByAgeRestriction(BookShopContext context, string command)
              {
                     if (!Enum.TryParse<AgeRestriction>(command, true, out var ageRestriction))
                     {
                            return $"{command} is not valid!";
                     }

                     var books = context.Books
                                          .Where(b => b.AgeRestriction == ageRestriction)
                                          .Select(b => b.Title)
                                          .OrderBy(b => b)
                                          .ToArray();
                     return string.Join("\n", books);
              }

              //03. Golden Books 
              public static string GetGoldenBooks(BookShopContext context)
              {
                     var books = context.Books
                                          .Where(b => b.Copies < 5000 && b.EditionType == EditionType.Gold)
                                          .OrderBy(b => b.BookId)
                                          .Select(b => b.Title)
                                          .ToArray();

                     return string.Join("\n", books);
              }

              //04. Books by Price 
              public static string GetBooksByPrice(BookShopContext context)
              {
                     var books = context.Books
                                          .Where(b => b.Price > 40)
                                          .OrderByDescending(b => b.Price)
                                          .Select(b => new
                                          {
                                                 b.Title,
                                                 b.Price,
                                          })
                                          .ToArray();

                     StringBuilder sb = new StringBuilder();

                     foreach (var book in books)
                     {
                            sb.AppendLine($"{book.Title} - ${book.Price:f2}");
                     }

                     return sb.ToString().Trim();


              }

              //05. Not Released In 
              public static string GetBooksNotReleasedIn(BookShopContext context, int year)
              {
                     var books = context.Books
                                          .Where(b => b.ReleaseDate.Value.Year != year)
                                          .Select(b => new
                                          {
                                                 b.BookId,
                                                 b.Title
                                          })
                                          .OrderBy(b => b.BookId)
                                          .ToArray();
                     StringBuilder sb = new StringBuilder();

                     foreach (var book in books) 
                     {
                            sb.AppendLine($"{book.Title}");
                     }

                     return sb.ToString();
              }

              //06. Book Titles by Category 
              public static string GetBooksByCategory(BookShopContext context, string input) 
              { 
                     string[] categories = input.ToLower().Split(" ").ToArray();
                     //var books = context.BooksCategories
                     //                     .AsNoTracking()
                     //                     .Where(bc=>categories.Contains(bc.Category.Name.ToLower()))
                     //                     .Select(bc=>bc.Book.Title)
                     //                     .OrderBy(bc=>bc)

                     var books = context.Books
                                          .AsNoTracking()
                                          .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                                          .Select(b=>b.Title)
                                          .OrderBy(b=>b)
                                          .ToArray();


                     StringBuilder sb = new StringBuilder();
                     foreach (var book in books) 
                     {
                            sb.AppendLine(book);
                     }

                     return sb.ToString();
              }

              //07. Released Before Date 
              public static string GetBooksReleasedBefore(BookShopContext context, string date) 
              {
                     return "";
              }
       }
}


