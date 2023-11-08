namespace BookShop
{
       using BookShop.Models.Enums;
       using Data;
       using Initializer;
       using System.Text;

       public class StartUp
       {
              public static void Main()
              {
                     using var db = new BookShopContext();

                     string command = Console.ReadLine();

                     string result = GetBooksByAgeRestriction(db, command);

                     Console.WriteLine(result);


                     DbInitializer.ResetDatabase(db);
              }

              public static string GetBooksByAgeRestriction(BookShopContext context, string command)
              {
                     if (!Enum.TryParse<AgeRestriction>(command, true, out AgeRestriction result))
                     {
                            return "";
                     }
                     var books = context.Books
                                          .Where(b => b.AgeRestriction == result)
                                          .Select(b => new
                                          {
                                                 b.Title
                                          })
                                          .OrderBy(b => b.Title)
                                          .ToArray();
                     StringBuilder sb = new StringBuilder();

                     foreach (var item in books)
                     {
                            sb.AppendLine(item.Title);
                     }

                     return sb.ToString().Trim();
              }
       }
}


