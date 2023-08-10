using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace T01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr =Console.ReadLine().Split(' ').ToArray();
            Action<string> print = name => Console.WriteLine(name); ;
            foreach (var item in arr)
            {
                print(item);
            } 
        }
    

    }
}
