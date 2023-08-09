using System;
using System.Collections.Generic;

namespace T03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Songs> list = new List<Songs>();
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                string[] input = data.Split("_");
                string typelist = input[0];
                string name = input[1];
                string time = input[2];
                Songs song = new Songs(typelist, name, time);
                list.Add(song);
            }
            string text = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                Songs currsong = list[i];
                if (text == "all")
                {
                    Console.WriteLine(currsong.Name);
                }
                else if(text == currsong.TypeList)
                {
                    Console.WriteLine(currsong.Name);
                }
            }
            
        }

        public class Songs
        {
            public Songs(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
