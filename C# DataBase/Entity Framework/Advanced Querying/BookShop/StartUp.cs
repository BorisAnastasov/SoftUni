namespace BookShop
{
       using BookShop.Models.Enums;
       using Data;
       using Initializer;
       using Microsoft.EntityFrameworkCore;
       using System.Text;

       public class StartUp
       {
              public static void Main()
              {
                     using var db = new BookShopContext();
                     DbInitializer.ResetDatabase(db);

                     int year = int.Parse(Console.ReadLine());

                     string result = GetBooksNotReleasedIn(db, year);
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
       }
}


