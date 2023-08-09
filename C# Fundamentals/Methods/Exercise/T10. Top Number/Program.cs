using System;

namespace T10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool top = false;
            bool odd = false;
            for (int i = 1; i <= n; i++)
            {
                string s = i.ToString();
                int sum = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j]%2 != 0)
                    {
                        odd = true;
                    }
                    sum += s[j];
                }
                if (sum % 8 == 0)
                {
                    top = true;
                }
                if(odd&& top)
                {
                    Console.WriteLine(i);
                }
                top = false;
                odd = false;

            }
        }
    }
}
