using System;
using System.Linq;

namespace T01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string word = Console.ReadLine();
                int length = word.Length;
                bool isVowel = false;
                for (int z = 0; z < length; z++)
                {
                    int score = word[z];
                    switch (word[z])
                    {
                        case 'a':
                            isVowel = true;
                            break;
                        case 'e':
                            isVowel = true;
                            break;
                        case 'i':
                            isVowel = true;
                            break;
                        case 'o':
                            isVowel = true;
                            break;
                        case 'u':
                            isVowel = true;
                            break;
                        case 'A':
                            isVowel = true;
                            break;
                        case 'E':
                            isVowel = true;
                            break;
                        case 'I':
                            isVowel = true;
                            break;
                        case 'O':
                            isVowel = true;
                            break;
                        case 'U':
                            isVowel = true;
                            break;
                    }
                    if (isVowel)
                    {
                        score *= length;
                    }
                    else
                    {
                        score = Math.Abs(score / length);
                    }
                    isVowel = false;
                    sum += score;
                }
                arr[i] = sum;
            }
            arr = arr.OrderBy(x=>x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
