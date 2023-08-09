using System;

namespace T01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vInt;
            double vFloat;
            char vCh;
            bool vBool;
            while(word != "END")
            {
                if(int.TryParse(word, out vInt))
                {
                    Console.WriteLine($"{word} is integer type");
                }
                else if (double.TryParse(word, out vFloat))
                {
                    Console.WriteLine($"{word} is floating point type");
                }
                else if (char.TryParse(word, out vCh))
                {
                    Console.WriteLine($"{word} is character type");
                }
                else if (bool.TryParse(word, out vBool))
                {
                    Console.WriteLine($"{word} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{word} is string type");
                }


                word = Console.ReadLine();
            }
            
        }
    }
}
