namespace MusicHub
{
       using Data;
       using Initializer;
       using System;
       using System.Text;

       public class StartUp
       {
              public static void Main()
              {
                     MusicHubDbContext context =
                         new MusicHubDbContext();

                     DbInitializer.ResetDatabase(context);

                     //Test your solutions here
                     Console.WriteLine(ExportSongsAboveDuration(context, 4));
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
                                   sb.AppendLine($"---#{i + 1}");
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


                     var songs = context.Songs
                                          .Where(s => s.Duration.TotalSeconds > duration)
                                          .Select(s => new
                                          {
                                                 s.Name,
                                                 WriterName = s.Writer.Name,
                                                 AlbumProducer = s.Album.Producer.Name,
                                                 Duration = s.Duration.ToString("c"),
                                                 Performers = s.SongPerformers
                                                        .Select(sp => new
                                                        {
                                                               FullName = sp.Performer.FirstName + ' ' + sp.Performer.LastName
                                                        })
                                                        .OrderBy(p=>p.FullName)
                                                        .ToList()

                                          })
                                          .OrderBy(s => s.Name)
                                          .ThenBy(s => s.WriterName)
                                          .ToList();


                     StringBuilder sb = new StringBuilder();
                     int count = 1;
                     foreach (var s in songs)
                     {
                            sb.AppendLine($"-Song #{count++}");
                            sb.AppendLine($"---SongName: {s.Name}");
                            sb.AppendLine($"---Writer: {s.WriterName}");

                            foreach (var p in s.Performers)
                            {
                                   sb.AppendLine($"---Performer: {p.FullName}");
                            }

                            sb.AppendLine($"---AlbumProducer: {s.AlbumProducer}");
                            sb.AppendLine($"---Duration: {s.Duration}");
                     }


                     return sb.ToString().Trim();
              }
       }
}
