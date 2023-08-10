namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            int diff = DateModifier.GetDifference(start, end);
            Console.WriteLine(diff);
        }
    }
}