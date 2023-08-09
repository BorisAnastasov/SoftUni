using System;
using System.Collections.Generic;

namespace T03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numart = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 0; i < numart; i++)
            {
                string[] data = Console.ReadLine().Split(", ");
                Article article = new Article()
                {
                    Title = data[0],
                    Content = data[1],
                    Author = data[2],
                    
                };
                list.Add(article);
                
            }
            string text = Console.ReadLine();
            foreach (Article article in list)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
        class Article 
        { 
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public List<Article> List { get; set; }
        }


    }
}
