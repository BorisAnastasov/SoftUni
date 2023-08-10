namespace T04.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    int r = int.Parse(arr[i]);
                    sum += r;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"The element '{arr[i]}' is in wrong format!");
                }
                catch(OverflowException ex) 
                {
                    Console.WriteLine($"The element '{arr[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{arr[i]}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}