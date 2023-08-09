using System;

namespace T05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;
            int count = 0;
            for(int i = username.Length-1; i >= 0; i--)
            {
                char curr = username[i];
                password += curr;
            }
            string trying = Console.ReadLine();
            while(trying != password)
            {
                if (count == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
             
                count++;
                trying = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
