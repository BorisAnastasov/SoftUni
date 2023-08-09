using System;

namespace T04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool amount =Between(password);
            bool letAndDig = LetterAndDigits(password);
            bool twoDigits = AtLest2Digits(password);
            if (!amount)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!letAndDig)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!twoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(amount&& letAndDig&& twoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool Between(string password)
        {
            bool valid = password.Length >=6 && password.Length <=10;
            return valid;

        }
        static bool LetterAndDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch)) return false;
                    
            }
            return true;
        }
        static bool AtLest2Digits(string password)
        {
            int digitCnt = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCnt++;
                }
            }
            return digitCnt >= 2;
        }
    }
}
