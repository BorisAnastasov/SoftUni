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
                     arr1.ForEach(armors.Enqueue);

                     Stack<int> strikes = new Stack<int>();
                     List<int> arr2 = Console.ReadLine().Split(",").Select(int.Parse).ToList();
                     arr2.ForEach(strikes.Push);

                     while (strikes.Any() && armors.Any())
                     {
                            int armor = armors.Dequeue();
                            int strike = strikes.Pop();
                            if (armor < strike)
                            {
                                   strike -= armor;
                                   if (strikes.Any())
                                   {
                                          strikes.Push(strikes.Pop() + strike);
                                   }
                                   else
                                   {
                                          strikes.Push(strike);
                                   }
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
                     if (!armors.Any())
                     {
                            Console.WriteLine("All monsters have been killed!");

                     }
                     if (!strikes.Any())//not said but id important that this is not else if
                     {
                            Console.WriteLine("The soldier has been defeated.");
                     }
                     
                     Console.WriteLine($"Total monsters killed: {monstersKilled}");
              }
       }
}
