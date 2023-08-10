using System.Security.Cryptography.X509Certificates;

namespace T05.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int count = 0;
            while (count != 3)
            {
                string[] info = Console.ReadLine().Split(" ").ToArray();
                string cmd = info[0];
                int range = arr.Length;
                try
                {
                    switch (cmd)
                    {
                        case "Replace":
                            int index = int.Parse(info[1]);
                            int elem = int.Parse(info[2]);
                            arr[index] = elem;                            
                            break;
                        case "Print":
                            int startIndex = int.Parse(info[1]);
                            int endIndex = int.Parse(info[2]);
                            List<int> list = new List<int>();   
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                list.Add(arr[i]);
                            }
                            Console.WriteLine(string.Join(", ",list));
                            break;
                        case "Show":
                            int ind = int.Parse(info[1]);
                            Console.WriteLine(arr[ind]);
                            break;
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("The index does not exist!");
                    count++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    count++;
                }

            }
            Console.WriteLine(string.Join(", ",arr));
        }
        public static void InRange(int range, int index)
        {
            if (range <= index && index < 0)
            {
                throw new OverflowException("The index does not exist!");
            }
        }
    }
}