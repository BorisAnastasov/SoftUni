using System;

namespace T02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            string str1 = words[0];
            string str2 = words[1];
            int lenght = 0;
            int leftLenght1 = 0;
            int leftLenght2 = 0;
            int sum = 0;
            if(str1.Length >= str2.Length)
            {
                lenght = str2.Length;
                leftLenght1 = str1.Length-str2.Length;
            }
            else
            {
                lenght = str1.Length;
                leftLenght2 = str2.Length - str1.Length;
            }
            for (int i = 0; i < lenght; i++)
            {
                int index1 = str1[i];
                int index2 = str2[i];
                int multi = index1 * index2;
                sum += multi;
            }
            if(leftLenght1 > 0)
            {
                for (int i = str1.Length-leftLenght1; i < str1.Length; i++)
                {
                    int index = str1[i];
                    sum += index;
                }
            }
            else if(leftLenght2 > 0)
            {
                for (int i = str2.Length - leftLenght2; i < str2.Length; i++)
                {
                    int index = str2[i];
                    sum += index;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
