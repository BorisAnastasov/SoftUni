using System;
using System.Collections.Generic;

namespace T01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Data data = new Data(phrases, events, authors, cities);
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                int pIndex = random.Next(0, phrases.Count);
                int eIndex = random.Next(0, events.Count);
                int aIndex = random.Next(0, authors.Count);
                int cIndex = random.Next(0, cities.Count);
                Console.WriteLine($"{data.Phrases[pIndex]} {data.Events[eIndex]} {data.Authors[aIndex]} – {data.Cities[cIndex]}.");
            }
        }
        public class Data
        {
            public Data(List<string> phrases, List<string> events, List<string> authors, List<string> cities)
            {
                Phrases = phrases;
                Events = events;
                Authors = authors;
                Cities = cities;
            }

            public List<string> Phrases { get; set; }
            public List<string> Events { get; set; }
            public List<string> Authors { get; set; }
            public List<string> Cities { get; set; }

        }
    }
}
