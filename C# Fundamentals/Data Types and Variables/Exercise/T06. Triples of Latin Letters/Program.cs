using System;

namespace T06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                char ich = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char jch = (char)('a' + j);
                    for (int t = 0; t < n; t++)
                    {
                        char tch = (char)('a' + t);
                        Console.Write($"{ich}{jch}{tch}");
                        Console.WriteLine();
                    }
                }
                
            }
        }
    }
}
