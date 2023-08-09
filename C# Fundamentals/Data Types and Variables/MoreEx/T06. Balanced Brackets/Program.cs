using System;

namespace T06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mc = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                mc++;
                string text = Console.ReadLine();
                
                if(text == "(")
                {
                    count--;
                    if (count ==-2)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    
                }
                else if(text  == ")")
                {
                    count++;
                    if (count != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    
                }
                
            }
            if(count == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
