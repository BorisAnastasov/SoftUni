using System;

namespace T04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var item in words)
            {
                string bann = "";
                for (int i = 0; i < item.Length; i++)
                {
                    bann += "*";
                }
                text = text.Replace(item, bann);
            }
            Console.WriteLine(text);
        }
        
    }
}
