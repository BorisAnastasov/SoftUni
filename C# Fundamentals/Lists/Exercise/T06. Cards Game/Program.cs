using System;
using System.Collections.Generic;
using System.Linq;
namespace T06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            while(firstDeck.Sum() !=0 && secondDeck.Sum() != 0)
            {
                if(firstDeck.Count() > secondDeck.Count())
                {
                    count = secondDeck.Count();
                }
                else if(firstDeck.Count() < secondDeck.Count())
                {
                    count = firstDeck.Count();
                }
                else
                {
                    count = firstDeck.Count();
                }
                for (int i = 0; i < count; i++)
                {
                    if (firstDeck[i] > secondDeck[i])
                    {
                        int secondPlayersCard = secondDeck[i];
                        int firstPlayersCard = firstDeck[i];
                        firstDeck.Add(firstPlayersCard);
                        firstDeck.Add(secondPlayersCard);                       
                        firstDeck.RemoveAt(i);
                        secondDeck.RemoveAt(i);
                        i--;
                        count--;

                    }
                    else if (firstDeck[i] < secondDeck[i])
                    {
                        int firstPlayersCard = firstDeck[i];
                        int secondPlayersCard = secondDeck[i];
                        secondDeck.Add(secondPlayersCard);
                        secondDeck.Add(firstPlayersCard);
                        firstDeck.RemoveAt(i);
                        secondDeck.RemoveAt(i);
                        i--;
                        count--;
                    }
                    //draw
                    else
                    {
                        firstDeck.RemoveAt(i);
                        secondDeck.RemoveAt(i);
                        i--;
                        count--;
                    }
                }
            }
            if(firstDeck.Sum() == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            
        }
    }
}
