namespace BookShop
{
       using BookShop.Models.Enums;
       using Data;
       using Initializer;
       using Microsoft.EntityFrameworkCore;
       using System.Text;
       using System.Linq;
       using Castle.DynamicProxy.Contributors;
       using System.Globalization;
       using Microsoft.Data.SqlClient.Server;

       public class StartUp
       {
              public static void Main()
              {
                     using var db = new BookShopContext();
                     DbInitializer.ResetDatabase(db);

                     //int n = int.Parse(Console.ReadLine());

                     string result = GetTotalProfitByCategory(db);
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
                                          .Select(b => b.Title)
                                          .OrderBy(b => b)
                                          .ToArray();


                     StringBuilder sb = new StringBuilder();
                     foreach (var book in books)
                     {
                            sb.AppendLine(book);
                     }

                     return sb.ToString();
              }

              //07. Released Before Date 
              public static string GetBooksReleasedBefore(BookShopContext context, string input)
              {
                     DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);

                     var books = context.Books
                         .AsNoTracking()
                         .Where(b => b.ReleaseDate < date)
                         .OrderByDescending(b => b.ReleaseDate)
                         .Select(b => new
                         {
                                Title = b.Title,
                                EditionType = b.EditionType,
                                Price = b.Price
                         })
                         .ToArray();

                     StringBuilder sb = new StringBuilder();
                     foreach (var book in books)
                     {
                            sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
                     }

                     return sb.ToString().TrimEnd();
              }

              //08. Author Search 
              public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
              {
                     var authors = context.Authors
                                .AsNoTracking()
                                .Where(a => a.FirstName.EndsWith(input))
                                .Select(a => a.FirstName + " " + a.LastName)
                                .OrderBy(a => a)
                                .ToArray();

                     StringBuilder sb = new StringBuilder();
                     foreach (var a in authors)
                     {
                            sb.AppendLine(a);
                     }

                     return sb.ToString().TrimEnd();
              }

              //09. Book Search 
              public static string GetBookTitlesContaining(BookShopContext context, string input)
              {
                     var books = context.Books
                                       .AsNoTracking()
                                       .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                                       .Select(b => b.Title)
                                       .OrderBy(b => b)
                                       .ToArray();

                     StringBuilder sb = new StringBuilder();
                     foreach (var b in books)
                     {
                            sb.AppendLine(b);
                     }

                     return sb.ToString().TrimEnd();
              }

              //10. Book Search by Author 
              public static string GetBooksByAuthor(BookShopContext context, string input)
              {
                     var books = context.Books
                                          .AsNoTracking()
                                          .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                                          .OrderBy(b => b.BookId)
                                          .Select(b => new
                                          {
                                                 b.Title,
                                                 Author = b.Author.FirstName + " " + b.Author.LastName
                                          })
                                          .ToArray();
                     StringBuilder sb = new StringBuilder();

                     foreach (var b in books)
                     {
                            sb.AppendLine($"{b.Title} ({b.Author})");
                     }
                     return sb.ToString();
              }

              //11. Count Books 
              public static int CountBooks(BookShopContext context, int lengthCheck)
              {
                     int numberOfBooks = context.Books
                                                 .Where(b => b.Title.Length > lengthCheck)
                                                 .Count();
                     return numberOfBooks;
              }

              //12. Total Book Copies 
              public static string CountCopiesByAuthor(BookShopContext context)
              {
                     var copiesPerAuthor = context.Authors
                                                        .Select(a => new
                                                        {
                                                               Name = a.FirstName + " " + a.LastName,
                                                               Copies = a.Books.Sum(b=>b.Copies)
                                                        })
                                                        .OrderByDescending(a=>a.Copies)
                                                        .ToArray();
                     StringBuilder sb = new StringBuilder();

                     foreach (var a in copiesPerAuthor)
                     {
                            sb.AppendLine($"{a.Name} - {a.Copies}");
                     }

                     return sb.ToString();
              }

              //13. Profit by Category 
              public static string GetTotalProfitByCategory(BookShopContext context) 
              {
                     var categories = context.Categories
                                                 .Select(c => new
                                                 {
                                                        c.Name,
                                                        Total = c.CategoryBooks.Sum(cb => cb.Book.Price * cb.Book.Copies)
                                                 })
                                                 .OrderByDescending(c => c.Total)
                                                 .ThenBy(c => c.Name)
                                                 .ToArray();
                     
                     StringBuilder sb = new StringBuilder();

                     foreach (var c in categories)
                     {
                            sb.AppendLine($"{c.Name} ${c.Total.ToString("f2")}");
                     }

                     return sb.ToString();
              }
       }
}


