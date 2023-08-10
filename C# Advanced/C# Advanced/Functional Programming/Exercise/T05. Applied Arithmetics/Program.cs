using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string word = Console.ReadLine();
            Func<List<int>, string, List<int>> calculation = (numbers, command) =>
            {
                List<int> result = new List<int>();
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i]++;
                            result.Add(numbers[i]);
                        }                        
                        break;
                    case "multiply":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i]*=2;
                            result.Add(numbers[i]);
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i]--;
                            result.Add(numbers[i]);
                        }
                        break;
                    case "print":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            result.Add(numbers[i]);
                        }
                        break;
                }
                return result;

            };

            while (word != "end")
            {
                arr = calculation(arr, word);
                if(word == "print")
                {
                    Console.WriteLine(String.Join(" ",arr));
                }
                word = Console.ReadLine();
            }
            

        }
    }
}
