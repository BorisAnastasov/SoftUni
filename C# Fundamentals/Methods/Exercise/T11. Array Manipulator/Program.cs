using System;
using System.Linq;
namespace T11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[] text = Console.ReadLine().Split(" ").ToArray();
            while (text[0] != "end")
            {
                switch (text[0])
                {
                    case "exchange":
                        int index = int.Parse(text[1]);
                        if (index > arr.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            while (index >= 0)
                            {
                                int curr = arr[0];

                                for (int i = 0; i < arr.Length - 1; i++)
                                {
                                    arr[i] = arr[i + 1];
                                }
                                arr[arr.Length - 1] = curr;

                                index--;
                            }
                        }
                        break;
                    case "max":
                        if (text[1] == "odd")
                        {
                            int max = int.MinValue;
                            int maxIndex = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] % 2 != 0 && arr[i] >= max)
                                {
                                    max = arr[i];
                                    maxIndex = i;
                                }
                            }
                            if (max == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxIndex);
                            }
                        }
                        else
                        {
                            int max = int.MinValue;
                            int maxIndex = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] % 2 == 0 && arr[i] >= max)
                                {
                                    max = arr[i];
                                    maxIndex = i;
                                }
                            }
                            if (max == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxIndex);
                            }
                        }
                        break;
                    case "min":
                        if (text[1] == "odd")
                        {
                            int min = int.MaxValue;
                            int minIndex = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] % 2 != 0 && arr[i] <= min)
                                {
                                    min = arr[i];
                                    minIndex = i;
                                }
                            }
                            if (min == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minIndex);
                            }
                        }
                        else
                        {
                            int min = int.MaxValue;
                            int minIndex = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] % 2 == 0 && arr[i] <= min)
                                {
                                    min = arr[i];
                                    minIndex = i;
                                }
                            }
                            if (min == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minIndex);
                            }
                        }
                        break;
                    case "first":
                        int count = int.Parse(text[1]);
                        if (count > arr.Length - 1)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            string t = text[2];
                            int n = 0;
                            int c = 1;

                            if (t == "even")
                            {
                                int[] k = new int[1]; ;
                                while (count > 0 || n == arr.Length - 1)
                                {

                                    for (int i = 0; i < arr.Length; i++)
                                    {
                                        if (arr[i] % 2 == 0)
                                        {
                                            c++;
                                        }
                                    }
                                    k = new int[c];
                                    for (int i = 0; i < arr.Length; i++)
                                    {
                                        if (arr[i] % 2 == 0)
                                        {
                                            k[i] = arr[i];
                                        }

                                    }

                                    n++;
                                    count--;
                                }
                                Console.WriteLine($"[{string.Join(", ", k)}]");
                            }
                            else
                            {
                                int[] k = new int[1]; ;
                                while (count > 0 || n == arr.Length - 1)
                                {

                                    for (int i = 0; i < arr.Length; i++)
                                    {
                                        if (arr[i] % 2 != 0)
                                        {
                                            c++;
                                        }
                                    }
                                    k = new int[c];
                                    for (int i = 0; i < arr.Length; i++)
                                    {
                                        if (arr[i] % 2 != 0)
                                        {
                                            k[i] = arr[i];
                                        }

                                    }

                                    n++;
                                    count--;
                                }
                                Console.WriteLine($"[{string.Join(", ", k)}]");
                            }
                        }
                        break;
                    case "last":
                        int count1 = int.Parse(text[1]);
                        if (count1 > arr.Length - 1)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            string t = text[2];
                            int n = 0;
                            int c = 1;

                            if (t == "even")
                            {
                                int[] k = new int[1]; ;
                                while (count1 > 0 || n == arr.Length - 1)
                                {

                                    for (int i = arr.Length - 1; i >= 0; i++)
                                    {
                                        if (arr[i] % 2 == 0)
                                        {
                                            c++;
                                        }
                                    }
                                    k = new int[c];
                                    for (int i = arr.Length - 1; i >= 0; i++)
                                    {
                                        if (arr[i] % 2 == 0)
                                        {
                                            k[i] = arr[i];
                                        }

                                    }

                                    n++;
                                    count1--;
                                }
                                Console.WriteLine($"[{string.Join(", ", k)}]");
                            }
                            else
                            {
                                int[] k = new int[1]; ;
                                while (count1 > 0 || n == arr.Length - 1)
                                {

                                    for (int i = arr.Length - 1; i >= 0; i++)
                                    {
                                        if (arr[i] % 2 != 0)
                                        {
                                            c++;
                                        }
                                    }
                                    k = new int[c];
                                    for (int i = arr.Length - 1; i >= 0; i++)
                                    {
                                        if (arr[i] % 2 != 0)
                                        {
                                            k[i] = arr[i];
                                        }

                                    }

                                    n++;
                                    count1--;
                                }
                                Console.WriteLine($"[{string.Join(", ", k)}]");
                            }
                        }
                        break;
                }
                text = Console.ReadLine().Split(" ").ToArray();
            }            
        }
    }
}
