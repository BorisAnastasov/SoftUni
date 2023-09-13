using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Monster_Extermination
{
       internal class Program
       {
              static void Main(string[] args)
              {
                     int monstersKilled = 0;
                     Queue<int> armors = new Queue<int>();
                     List<int> arr1 = Console.ReadLine().Split(",").Select(int.Parse).ToList();
                     arr1.ForEach(i => armors.Enqueue(i));

                     Stack<int> strikes = new Stack<int>();
                     List<int> arr2 = Console.ReadLine().Split(",").Select(int.Parse).ToList();
                     arr2.ForEach(i => strikes.Push(i));

                     while (strikes.Any() && armors.Any())
                     {
                            int armor = armors.Dequeue();
                            int strike = strikes.Pop();
                            if (armor < strike)
                            {
                                   strike -= armor;
                                   strikes.Push(strikes.Pop() + strike);
                                   monstersKilled++;
                            }
                            else if (armor > strike)
                            {
                                   armor -= strike;
                                   armors.Enqueue(armor);
                            }
                            else
                            {
                                   monstersKilled++;
                            }
                     }
                     if (!strikes.Any())
                     {
                            Console.WriteLine("The soldier has been defeated.");
                     }
                     else if (!armors.Any())
                     {
                            Console.WriteLine("All monsters have been killed!");

                     }
                     Console.WriteLine($"Total monsters killed: {monstersKilled}");
              }
       }
}
