namespace MusicHub
{
       using System;
       using System.Text;
       using Data;
       using Initializer;

       public class StartUp
       {
              public static void Main()
              {
                     MusicHubDbContext context =
                         new MusicHubDbContext();

                     DbInitializer.ResetDatabase(context);

                     //Test your solutions here
                     string result = ExportAlbumsInfo(context, 4);
                     Console.WriteLine(result);
              }

              public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
              {
                     StringBuilder sb = new StringBuilder();

                     var albums = context.Producers
                                          .First(p => p.Id == producerId).Albums
                                          .Select(a => new
                                          {
                                                 a.Name,
                                                 ReleaseDate = $"{a.ReleaseDate.Month:D2}/{a.ReleaseDate.Day:D2}/{a.ReleaseDate.Year}",
                                                 ProducerName = a.Producer.Name,
                                                 TotalAlbumPrice = a.Price,
                                                 Songs = a.Songs.Select(s => new
                                                 {
                                                        s.Name,
                                                        Price = s.Price.ToString("f2"),
                                                        WriterName = s.Writer.Name
                                                 })
                                                 .OrderByDescending(s => s.Name)
                                                 .ThenBy(s => s.WriterName)
                                                 .ToArray()
                                          })
                                          .OrderByDescending(a => a.TotalAlbumPrice)
                                          .ToArray();
                     foreach (var a in albums)
                     {
                            sb.AppendLine($"-AlbumName: {a.Name}");
                            sb.AppendLine($"-ReleaseDate: {a.ReleaseDate}");
                            sb.AppendLine($"-ProducerName: {a.ProducerName}");
                            sb.AppendLine("-Songs:");

                            for (int i = 0; i < a.Songs.Length; i++)
                            {
                                   sb.AppendLine($"---#{i+1}");
                                   sb.AppendLine($"---SongName: {a.Songs[i].Name}");
                                   sb.AppendLine($"---Price: {a.Songs[i].Price}");
                                   sb.AppendLine($"---Writer: {a.Songs[i].WriterName}");
                            }
                            sb.AppendLine($"-AlbumPrice: {a.TotalAlbumPrice.ToString("f2")}");
                     }
                     return sb.ToString().Trim();
              }

              public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
              {
                     throw new NotImplementedException();
              }
       }
}
