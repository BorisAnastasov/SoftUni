using System;

namespace T02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = Vowels(text);   
            Console.WriteLine(sum);
        }
        static int Vowels(string text)
        {
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' ||
            text[i] == 'i' || text[i] == 'o' ||
            text[i] == 'u' || text[i] == 'A' ||
            text[i] == 'E' || text[i] == 'I' ||
            text[i] == 'O' || text[i] == 'U')
                {

                    // Increment the vowels
                    sum++;
                }
            }
            return sum;
        }
    }
}
