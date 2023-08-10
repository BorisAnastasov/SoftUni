using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace T09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new Dictionary<string, InfoStudent>();//name, [language, score]
            var lang = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split("-").ToArray();
            while (input[0] != "exam finished")
            {
                string username = input[0];
                if (input[1] == "banned")
                {
                    if (list.ContainsKey(username))
                    {
                        list.Remove(username);
                    }
                }
                else
                {
                    string language = input[1];
                    int score = int.Parse(input[2]);
                    if (!list.ContainsKey(username))
                    {
                        list.Add(username, new InfoStudent() { Language = language, Score = score});
                    }
                    else
                    {
                        if (list[username].Language == language)
                        {
                            if (list[username].Score < score)
                            {
                                list[username].Score = score;
                            }
                        }                        
                    }
                    if (!lang.ContainsKey(language))
                    {
                        lang.Add(language, 1);
                    }
                    else
                    {
                        lang[language]++;
                    }
                    
                }               
                input = Console.ReadLine().Split("-").ToArray();
            }
            Console.WriteLine("Results:");
            foreach (var item in list.OrderByDescending(x=>x.Value.Score).ThenBy(x => x.Key))
            {
                
                    Console.WriteLine($"{item.Key} | {item.Value.Score}");
               
                             
            }
            Console.WriteLine("Submissions:");
            foreach (var item in lang.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        public class InfoStudent
        {
            public string Language { get; set; }
            public int Score { get; set; }
        }
    }
}
