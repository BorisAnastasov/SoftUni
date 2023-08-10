namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Elder list = new Elder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ").ToArray();
                string name = arr[0];
                int age = int.Parse(arr[1]);
                Person person = new(name, age);
                list.Add(person);
            }
            list.Print();
        }
        
    }
}