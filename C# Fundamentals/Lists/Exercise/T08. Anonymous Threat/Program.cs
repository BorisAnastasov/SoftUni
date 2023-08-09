using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(" ").ToList();
            string text = Console.ReadLine();
            while(text != "3:1")
            {
                string[] command = text.Split(" ").ToArray();
                if (command[0] == "merge")
                {
                    Merge(data,command);
                }
                else if (command[0] == "divide")
                {
                    Divide(data, command);
                }
                text = Console.ReadLine(); 
            }
            Console.WriteLine(string.Join(" ",data));
        }
        static void Merge(List<string> data, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > data.Count - 1)
            {
                endIndex = data.Count - 1;
            }
            for (int i = startIndex; i <= endIndex - 1; i++)
            {
                data[startIndex] += data[i + 1];
                data.Remove(data[i + 1]);
                i--;
                endIndex--;
            }
        }
        static void Divide(List<string> data, string[] command)
        {

        }

    }
}
