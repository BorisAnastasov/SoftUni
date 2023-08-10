using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Transactions;

namespace T06.MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            string[] input = Console.ReadLine().Split(",").ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string[] arr = input[i].Split("-");
                int number = int.Parse(arr[0]);
                double balance = double.Parse(arr[1]);
                BankAccount bankAccount = new(number, balance); 
                accounts.Add(bankAccount);
            }
            string command = Console.ReadLine();
            while(command != "End") 
            {
                string[] info = command.Split(" ").ToArray();
                string cmd = info[0];
                int number = int.Parse(info[1]);
                double balance = double.Parse(info[2]);

                try
                {
                    switch (cmd)
                    {
                        case "Deposit":
                            if(BankAccount.Constains(accounts, number))
                            {
                                foreach (var item in accounts)
                                {
                                    if (item.Number == number)
                                    {
                                        item.Balance += balance;
                                        Console.WriteLine($"Account {item.Number} has new balance: {item.Balance:f2}");
                                    }
                                }
                            }
                            else
                            {
                                throw new FormatException();
                            }
                            
                            break;
                        case "Withdraw":
                            if(BankAccount.Constains(accounts, number))
                            {
                                foreach (var item in accounts)
                                {
                                    if (item.Number == number)
                                    {
                                        if (item.Balance >= balance)
                                        {
                                            item.Balance-= balance;
                                            Console.WriteLine($"Account {item.Number} has new balance: {item.Balance:f2}");
                                        }
                                        else
                                        {
                                            throw new OverflowException();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                throw new FormatException();
                            }
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid account!");
                
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid command!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }

                command = Console.ReadLine();
            }
            
        }
    }
    public class BankAccount
    {
        private int number;
        private double balance;

        public BankAccount(int number, double balance)
        {
            Number = number;
            Balance = balance;
        }

        public int Number { get; set; }
        public double Balance { get; set; }
        public static bool Constains(List<BankAccount> accounts, int number)
        {
            foreach (BankAccount account in accounts) 
            { 
              if(account.Number == number) return true;           
            }
            return false;
        } 
    }
}