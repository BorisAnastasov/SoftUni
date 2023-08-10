namespace T03.Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            string[] phoneNumbers = Console.ReadLine().Split(" ").ToArray();
            string[] websites = Console.ReadLine().Split(" ").ToArray();
            foreach (string item in phoneNumbers)
            {
                if (IsDig(item))
                {
                    if (item.Length == 10)
                    {//smartphone
                        smartphone.AddingPhones(item);
                        smartphone.Calling(item);
                    }
                    else if (item.Length == 7)
                    {//stationphone
                        stationaryPhone.AddingPhones(item);
                        stationaryPhone.Calling(item);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            foreach (var item in websites)
            {
                if (IsURL(item))
                {
                    smartphone.AddingWeb(item);
                    smartphone.Browsing(item);
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
        public static bool IsDig(string number)
        {
            foreach (char item in number)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsURL(string number)
        {
            foreach (char item in number)
            {
                if (char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}